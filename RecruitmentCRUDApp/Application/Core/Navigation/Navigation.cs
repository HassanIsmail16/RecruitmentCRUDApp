using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentApplication.Core.Navigation
{
    internal class Navigation : INavigation
    {
        private readonly Panel container;
        private readonly Dictionary<Type, Func<object>> controllerFactories = new();
        private readonly Dictionary<Type, object> controllers = new();
        private readonly Dictionary<Type, UserControl> views = new();

        public Navigation(Panel container)
        {
            this.container = container;
        }

        public void NavigateTo<TView>() where TView : UserControl
        {
            if (!controllerFactories.TryGetValue(typeof(TView), out var factory))
            {
                throw new InvalidOperationException($"View {typeof(TView).Name} is not registered");
            }

            // Get or create controller instance
            if (!controllers.TryGetValue(typeof(TView), out var controller))
            {
                controller = factory();
                controllers[typeof(TView)] = controller;
            }

            // Get or create view instance
            UserControl view;
            if (!views.TryGetValue(typeof(TView), out view))
            {
                view = Activator.CreateInstance<TView>();
                views[typeof(TView)] = view;

                // Bind the view to its controller
                var bindMethod = controller.GetType().GetMethod("BindView");
                if (bindMethod != null)
                {
                    bindMethod.Invoke(controller, new object[] { view });
                }
                else
                {
                    // Log if the BindView method doesn't exist
                    Debug.WriteLine($"Warning: Controller {controller.GetType().Name} does not have a BindView method");
                }
            }

            // Display the view in the container panel
            container.SuspendLayout();
            container.Controls.Clear();
            view.Dock = DockStyle.Fill;
            container.Controls.Add(view);
            container.ResumeLayout();
        }

        public void RegisterView<TView, TController>(Func<TController> controllerFactory)
            where TView : UserControl
            where TController : class
        {
            controllerFactories[typeof(TView)] = controllerFactory;
        }
    }
}
