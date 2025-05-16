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

        public Navigation(Panel container)
        {
            this.container = container;
        }

        public void NavigateTo<TView>() where TView : UserControl
        {
            if (!controllerFactories.TryGetValue(typeof(TView), out var factory))
            {
                throw new InvalidOperationException($"View {typeof(TView).Name} is not registered");
            } // if the controller does not have a registered factory, throw an exception

            if (!controllers.TryGetValue(typeof(TView), out var controller))
            {
                controller = factory();
                controllers[typeof(TView)] = controller;
            } // if the view is not registered, register it, if it is, get the controller

            var view = Activator.CreateInstance<TView>(); // create a view instance

            // binds view to the controller
            var bindMethod = controller.GetType().GetMethod("BindView");
            bindMethod?.Invoke(controller, new object[] { view });

            // displays the view in the central panel
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
