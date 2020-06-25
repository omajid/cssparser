// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.WebTools.Languages.Css.TreeItems.PropertyValues
{
    internal sealed class PropertyValueBlock : UnknownBlock
    {
        public PropertyValueBlock()
        {
        }

        protected override bool IsBlockValid
        {
            get { return true; }
        }
    }
}
