using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Rn.Demo.RNRnDemo
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNRnDemoModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNRnDemoModule"/>.
        /// </summary>
        internal RNRnDemoModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNRnDemo";
            }
        }
    }
}
