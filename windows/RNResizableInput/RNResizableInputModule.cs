using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Resizable.Input.RNResizableInput
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNResizableInputModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNResizableInputModule"/>.
        /// </summary>
        internal RNResizableInputModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNResizableInput";
            }
        }
    }
}
