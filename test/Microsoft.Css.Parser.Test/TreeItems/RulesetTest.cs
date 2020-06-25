// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.WebTools.Languages.Css.Parser;
using Microsoft.WebTools.Languages.Css.Text;
using Microsoft.WebTools.Languages.Css.Tokens;
using Microsoft.WebTools.Languages.Css.TreeItems;

namespace Microsoft.WebTools.Languages.Css.Test.TreeItems
{
    [TestClass]
    public class RulesetTest : CssUnitTestBase
    {
        [TestMethod]
        public void Ruleset_ParseTest()
        {
            RuleSet target = new RuleSet();
            string text = ".a { }";
            ITextProvider tp = new StringTextProvider(text);
            TokenStream tokens = Helpers.MakeTokenStream(tp);
            bool actual = target.Parse(new ItemFactory(tp, null), tp, tokens);
            Assert.AreEqual(true, actual);
        }
    }
}
