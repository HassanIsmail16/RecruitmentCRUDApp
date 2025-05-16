using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentApplication.Core.Navigation
{
    /// <summary>
    /// An interface to be used in navigation between views in the central panel
    /// </summary>
    internal interface INavigation
    {
        /// <summary>
        /// Used to navigate between user controls in the central panel
        /// Pass the control you want to navigate to as a generic argument and it'll navigate there
        /// It'll hook the controller with the view automatically (if the view is registered)
        /// </summary>
        /// <typeparam name="TView">The control you want to navigate to</typeparam>
        void NavigateTo<TView>() where TView : UserControl;

        /// <summary>
        /// Used to register the view with a controller factory (construction method)
        /// </summary>
        /// <typeparam name="TView">The view to be registered</typeparam>
        /// <typeparam name="TController">The controller to be registered</typeparam>
        /// <param name="controllerFactory">The method to be used to construct the controller</param>
        void RegisterView<TView, TController>(Func<TController> controllerFactory)
            where TView : UserControl
            where TController : class;
    }
}
