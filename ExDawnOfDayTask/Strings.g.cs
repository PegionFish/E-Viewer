#pragma checksum "C:\Users\lzy\Documents\Source\ExViewer\ExDawnOfDayTask\Strings\en\Resources.resjson" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0F238DF07D52C197136A5CF0CF95D2D3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ExDawnOfDayTask.ResourceInfo
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Opportunity.ResourceGenerator", "1.3.8.0")]
    internal interface IResources : global::Opportunity.ResourceGenerator.IResourceProvider
    {
        global::ExDawnOfDayTask.ResourceInfo.Resources.IDawnOfDayToast DawnOfDayToast { get; }
    }
}

namespace ExDawnOfDayTask.ResourceInfo.Resources
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Opportunity.ResourceGenerator", "1.3.8.0")]
    internal interface IDawnOfDayToast : global::Opportunity.ResourceGenerator.IResourceProvider
    {
        /// <summary>
        /// <para>You gain {reward1}!</para>
        /// </summary>
        global::Opportunity.ResourceGenerator.FormattableResourceString Content1();
        /// <summary>
        /// <para>You gain {reward1}!</para>
        /// </summary>
        string Content1(object reward1);
        /// <summary>
        /// <para>You gain {reward1}!</para>
        /// </summary>
        string Content1(global::System.IFormatProvider provider, object reward1);
        /// <summary>
        /// <para>You gain {reward1} and {reward2}!</para>
        /// </summary>
        global::Opportunity.ResourceGenerator.FormattableResourceString Content2();
        /// <summary>
        /// <para>You gain {reward1} and {reward2}!</para>
        /// </summary>
        string Content2(object reward1, object reward2);
        /// <summary>
        /// <para>You gain {reward1} and {reward2}!</para>
        /// </summary>
        string Content2(global::System.IFormatProvider provider, object reward1, object reward2);
        /// <summary>
        /// <para>You gain {reward1}, {reward2} and {reward3}!</para>
        /// </summary>
        global::Opportunity.ResourceGenerator.FormattableResourceString Content3();
        /// <summary>
        /// <para>You gain {reward1}, {reward2} and {reward3}!</para>
        /// </summary>
        string Content3(object reward1, object reward2, object reward3);
        /// <summary>
        /// <para>You gain {reward1}, {reward2} and {reward3}!</para>
        /// </summary>
        string Content3(global::System.IFormatProvider provider, object reward1, object reward2, object reward3);
        /// <summary>
        /// <para>You gain {reward1}, {reward2}, {reward3} and {reward4}!</para>
        /// </summary>
        global::Opportunity.ResourceGenerator.FormattableResourceString Content4();
        /// <summary>
        /// <para>You gain {reward1}, {reward2}, {reward3} and {reward4}!</para>
        /// </summary>
        string Content4(object reward1, object reward2, object reward3, object reward4);
        /// <summary>
        /// <para>You gain {reward1}, {reward2}, {reward3} and {reward4}!</para>
        /// </summary>
        string Content4(global::System.IFormatProvider provider, object reward1, object reward2, object reward3, object reward4);
        /// <summary>
        /// <para>{value} Credits</para>
        /// </summary>
        global::Opportunity.ResourceGenerator.FormattableResourceString RewardCredits();
        /// <summary>
        /// <para>{value} Credits</para>
        /// </summary>
        string RewardCredits(object value);
        /// <summary>
        /// <para>{value} Credits</para>
        /// </summary>
        string RewardCredits(global::System.IFormatProvider provider, object value);
        /// <summary>
        /// <para>{value} EXP</para>
        /// </summary>
        global::Opportunity.ResourceGenerator.FormattableResourceString RewardExp();
        /// <summary>
        /// <para>{value} EXP</para>
        /// </summary>
        string RewardExp(object value);
        /// <summary>
        /// <para>{value} EXP</para>
        /// </summary>
        string RewardExp(global::System.IFormatProvider provider, object value);
        /// <summary>
        /// <para>{value} GP</para>
        /// </summary>
        global::Opportunity.ResourceGenerator.FormattableResourceString RewardGp();
        /// <summary>
        /// <para>{value} GP</para>
        /// </summary>
        string RewardGp(object value);
        /// <summary>
        /// <para>{value} GP</para>
        /// </summary>
        string RewardGp(global::System.IFormatProvider provider, object value);
        /// <summary>
        /// <para>{value} Hath</para>
        /// </summary>
        global::Opportunity.ResourceGenerator.FormattableResourceString RewardHath();
        /// <summary>
        /// <para>{value} Hath</para>
        /// </summary>
        string RewardHath(object value);
        /// <summary>
        /// <para>{value} Hath</para>
        /// </summary>
        string RewardHath(global::System.IFormatProvider provider, object value);
        /// <summary>
        /// <para>It is the dawn of a new day!</para>
        /// </summary>
        string Title { get; }
    }
}

namespace ExDawnOfDayTask
{
    [global::System.Diagnostics.DebuggerTypeProxyAttribute(typeof(global::Opportunity.ResourceGenerator.DebuggerDisplay))]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Opportunity.ResourceGenerator", "1.3.8.0")]
    internal static class Strings
    {

        [global::System.Diagnostics.DebuggerBrowsableAttribute(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        private static global::ExDawnOfDayTask.ResourceInfo.IResources Resources__0nElYILr;
        internal static global::ExDawnOfDayTask.ResourceInfo.IResources Resources 
            => global::System.Threading.LazyInitializer.EnsureInitialized(ref Resources__0nElYILr, () => new global::ExDawnOfDayTask.Strings.Resources__GxZK2xSh());

        [global::System.Diagnostics.DebuggerTypeProxyAttribute(typeof(global::Opportunity.ResourceGenerator.DebuggerDisplay))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Opportunity.ResourceGenerator", "1.3.8.0")]
        private sealed class Resources__GxZK2xSh : global::Opportunity.ResourceGenerator.ResourceProviderBase, global::ExDawnOfDayTask.ResourceInfo.IResources
        {
            public Resources__GxZK2xSh() : base("ms-resource:///ExDawnOfDayTask/Resources/") { }


            [global::System.Diagnostics.DebuggerBrowsableAttribute(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::ExDawnOfDayTask.ResourceInfo.Resources.IDawnOfDayToast DawnOfDayToast__xx9raFZc;
            [global::Opportunity.ResourceGenerator.ResourcePathAttribute("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast")]
            global::ExDawnOfDayTask.ResourceInfo.Resources.IDawnOfDayToast global::ExDawnOfDayTask.ResourceInfo.IResources.DawnOfDayToast 
                => global::System.Threading.LazyInitializer.EnsureInitialized(ref this.DawnOfDayToast__xx9raFZc, () => new global::ExDawnOfDayTask.Strings.Resources__GxZK2xSh.DawnOfDayToast__XwpRQFj3());

            [global::System.Diagnostics.DebuggerTypeProxyAttribute(typeof(global::Opportunity.ResourceGenerator.DebuggerDisplay))]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Opportunity.ResourceGenerator", "1.3.8.0")]
            private sealed class DawnOfDayToast__XwpRQFj3 : global::Opportunity.ResourceGenerator.ResourceProviderBase, global::ExDawnOfDayTask.ResourceInfo.Resources.IDawnOfDayToast
            {
                public DawnOfDayToast__XwpRQFj3() : base("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/") { }

                global::Opportunity.ResourceGenerator.FormattableResourceString Content1__Uu9Y78YQ;
                [global::Opportunity.ResourceGenerator.ResourcePathAttribute("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$Content1")]
                global::Opportunity.ResourceGenerator.FormattableResourceString global::ExDawnOfDayTask.ResourceInfo.Resources.IDawnOfDayToast.Content1()
                {
                    if (Content1__Uu9Y78YQ == null)
                        Content1__Uu9Y78YQ = new global::Opportunity.ResourceGenerator.FormattableResourceString(global::Opportunity.Helpers.Universal.LocalizedStrings.GetValue("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$Content1"));
                    return Content1__Uu9Y78YQ;
                }
                string global::ExDawnOfDayTask.ResourceInfo.Resources.IDawnOfDayToast.Content1(object reward1)
                {
                    if (Content1__Uu9Y78YQ == null)
                        Content1__Uu9Y78YQ = new global::Opportunity.ResourceGenerator.FormattableResourceString(global::Opportunity.Helpers.Universal.LocalizedStrings.GetValue("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$Content1"));
                    return string.Format(Content1__Uu9Y78YQ.FormatString, reward1);
                }
                string global::ExDawnOfDayTask.ResourceInfo.Resources.IDawnOfDayToast.Content1(global::System.IFormatProvider provider, object reward1)
                {
                    if (Content1__Uu9Y78YQ == null)
                        Content1__Uu9Y78YQ = new global::Opportunity.ResourceGenerator.FormattableResourceString(global::Opportunity.Helpers.Universal.LocalizedStrings.GetValue("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$Content1"));
                    return string.Format(provider, Content1__Uu9Y78YQ.FormatString, reward1);
                }
                global::Opportunity.ResourceGenerator.FormattableResourceString Content2__xfp6pQEa;
                [global::Opportunity.ResourceGenerator.ResourcePathAttribute("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$Content2")]
                global::Opportunity.ResourceGenerator.FormattableResourceString global::ExDawnOfDayTask.ResourceInfo.Resources.IDawnOfDayToast.Content2()
                {
                    if (Content2__xfp6pQEa == null)
                        Content2__xfp6pQEa = new global::Opportunity.ResourceGenerator.FormattableResourceString(global::Opportunity.Helpers.Universal.LocalizedStrings.GetValue("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$Content2"));
                    return Content2__xfp6pQEa;
                }
                string global::ExDawnOfDayTask.ResourceInfo.Resources.IDawnOfDayToast.Content2(object reward1, object reward2)
                {
                    if (Content2__xfp6pQEa == null)
                        Content2__xfp6pQEa = new global::Opportunity.ResourceGenerator.FormattableResourceString(global::Opportunity.Helpers.Universal.LocalizedStrings.GetValue("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$Content2"));
                    return string.Format(Content2__xfp6pQEa.FormatString, reward1, reward2);
                }
                string global::ExDawnOfDayTask.ResourceInfo.Resources.IDawnOfDayToast.Content2(global::System.IFormatProvider provider, object reward1, object reward2)
                {
                    if (Content2__xfp6pQEa == null)
                        Content2__xfp6pQEa = new global::Opportunity.ResourceGenerator.FormattableResourceString(global::Opportunity.Helpers.Universal.LocalizedStrings.GetValue("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$Content2"));
                    return string.Format(provider, Content2__xfp6pQEa.FormatString, reward1, reward2);
                }
                global::Opportunity.ResourceGenerator.FormattableResourceString Content3__vVhLMXfc;
                [global::Opportunity.ResourceGenerator.ResourcePathAttribute("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$Content3")]
                global::Opportunity.ResourceGenerator.FormattableResourceString global::ExDawnOfDayTask.ResourceInfo.Resources.IDawnOfDayToast.Content3()
                {
                    if (Content3__vVhLMXfc == null)
                        Content3__vVhLMXfc = new global::Opportunity.ResourceGenerator.FormattableResourceString(global::Opportunity.Helpers.Universal.LocalizedStrings.GetValue("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$Content3"));
                    return Content3__vVhLMXfc;
                }
                string global::ExDawnOfDayTask.ResourceInfo.Resources.IDawnOfDayToast.Content3(object reward1, object reward2, object reward3)
                {
                    if (Content3__vVhLMXfc == null)
                        Content3__vVhLMXfc = new global::Opportunity.ResourceGenerator.FormattableResourceString(global::Opportunity.Helpers.Universal.LocalizedStrings.GetValue("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$Content3"));
                    return string.Format(Content3__vVhLMXfc.FormatString, reward1, reward2, reward3);
                }
                string global::ExDawnOfDayTask.ResourceInfo.Resources.IDawnOfDayToast.Content3(global::System.IFormatProvider provider, object reward1, object reward2, object reward3)
                {
                    if (Content3__vVhLMXfc == null)
                        Content3__vVhLMXfc = new global::Opportunity.ResourceGenerator.FormattableResourceString(global::Opportunity.Helpers.Universal.LocalizedStrings.GetValue("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$Content3"));
                    return string.Format(provider, Content3__vVhLMXfc.FormatString, reward1, reward2, reward3);
                }
                global::Opportunity.ResourceGenerator.FormattableResourceString Content4__Xlr0YXaF;
                [global::Opportunity.ResourceGenerator.ResourcePathAttribute("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$Content4")]
                global::Opportunity.ResourceGenerator.FormattableResourceString global::ExDawnOfDayTask.ResourceInfo.Resources.IDawnOfDayToast.Content4()
                {
                    if (Content4__Xlr0YXaF == null)
                        Content4__Xlr0YXaF = new global::Opportunity.ResourceGenerator.FormattableResourceString(global::Opportunity.Helpers.Universal.LocalizedStrings.GetValue("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$Content4"));
                    return Content4__Xlr0YXaF;
                }
                string global::ExDawnOfDayTask.ResourceInfo.Resources.IDawnOfDayToast.Content4(object reward1, object reward2, object reward3, object reward4)
                {
                    if (Content4__Xlr0YXaF == null)
                        Content4__Xlr0YXaF = new global::Opportunity.ResourceGenerator.FormattableResourceString(global::Opportunity.Helpers.Universal.LocalizedStrings.GetValue("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$Content4"));
                    return string.Format(Content4__Xlr0YXaF.FormatString, reward1, reward2, reward3, reward4);
                }
                string global::ExDawnOfDayTask.ResourceInfo.Resources.IDawnOfDayToast.Content4(global::System.IFormatProvider provider, object reward1, object reward2, object reward3, object reward4)
                {
                    if (Content4__Xlr0YXaF == null)
                        Content4__Xlr0YXaF = new global::Opportunity.ResourceGenerator.FormattableResourceString(global::Opportunity.Helpers.Universal.LocalizedStrings.GetValue("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$Content4"));
                    return string.Format(provider, Content4__Xlr0YXaF.FormatString, reward1, reward2, reward3, reward4);
                }
                global::Opportunity.ResourceGenerator.FormattableResourceString RewardCredits__O_K8gtD7;
                [global::Opportunity.ResourceGenerator.ResourcePathAttribute("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$RewardCredits")]
                global::Opportunity.ResourceGenerator.FormattableResourceString global::ExDawnOfDayTask.ResourceInfo.Resources.IDawnOfDayToast.RewardCredits()
                {
                    if (RewardCredits__O_K8gtD7 == null)
                        RewardCredits__O_K8gtD7 = new global::Opportunity.ResourceGenerator.FormattableResourceString(global::Opportunity.Helpers.Universal.LocalizedStrings.GetValue("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$RewardCredits"));
                    return RewardCredits__O_K8gtD7;
                }
                string global::ExDawnOfDayTask.ResourceInfo.Resources.IDawnOfDayToast.RewardCredits(object value)
                {
                    if (RewardCredits__O_K8gtD7 == null)
                        RewardCredits__O_K8gtD7 = new global::Opportunity.ResourceGenerator.FormattableResourceString(global::Opportunity.Helpers.Universal.LocalizedStrings.GetValue("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$RewardCredits"));
                    return string.Format(RewardCredits__O_K8gtD7.FormatString, value);
                }
                string global::ExDawnOfDayTask.ResourceInfo.Resources.IDawnOfDayToast.RewardCredits(global::System.IFormatProvider provider, object value)
                {
                    if (RewardCredits__O_K8gtD7 == null)
                        RewardCredits__O_K8gtD7 = new global::Opportunity.ResourceGenerator.FormattableResourceString(global::Opportunity.Helpers.Universal.LocalizedStrings.GetValue("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$RewardCredits"));
                    return string.Format(provider, RewardCredits__O_K8gtD7.FormatString, value);
                }
                global::Opportunity.ResourceGenerator.FormattableResourceString RewardExp__ULK_7okl;
                [global::Opportunity.ResourceGenerator.ResourcePathAttribute("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$RewardExp")]
                global::Opportunity.ResourceGenerator.FormattableResourceString global::ExDawnOfDayTask.ResourceInfo.Resources.IDawnOfDayToast.RewardExp()
                {
                    if (RewardExp__ULK_7okl == null)
                        RewardExp__ULK_7okl = new global::Opportunity.ResourceGenerator.FormattableResourceString(global::Opportunity.Helpers.Universal.LocalizedStrings.GetValue("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$RewardExp"));
                    return RewardExp__ULK_7okl;
                }
                string global::ExDawnOfDayTask.ResourceInfo.Resources.IDawnOfDayToast.RewardExp(object value)
                {
                    if (RewardExp__ULK_7okl == null)
                        RewardExp__ULK_7okl = new global::Opportunity.ResourceGenerator.FormattableResourceString(global::Opportunity.Helpers.Universal.LocalizedStrings.GetValue("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$RewardExp"));
                    return string.Format(RewardExp__ULK_7okl.FormatString, value);
                }
                string global::ExDawnOfDayTask.ResourceInfo.Resources.IDawnOfDayToast.RewardExp(global::System.IFormatProvider provider, object value)
                {
                    if (RewardExp__ULK_7okl == null)
                        RewardExp__ULK_7okl = new global::Opportunity.ResourceGenerator.FormattableResourceString(global::Opportunity.Helpers.Universal.LocalizedStrings.GetValue("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$RewardExp"));
                    return string.Format(provider, RewardExp__ULK_7okl.FormatString, value);
                }
                global::Opportunity.ResourceGenerator.FormattableResourceString RewardGp__SeKqFJuH;
                [global::Opportunity.ResourceGenerator.ResourcePathAttribute("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$RewardGp")]
                global::Opportunity.ResourceGenerator.FormattableResourceString global::ExDawnOfDayTask.ResourceInfo.Resources.IDawnOfDayToast.RewardGp()
                {
                    if (RewardGp__SeKqFJuH == null)
                        RewardGp__SeKqFJuH = new global::Opportunity.ResourceGenerator.FormattableResourceString(global::Opportunity.Helpers.Universal.LocalizedStrings.GetValue("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$RewardGp"));
                    return RewardGp__SeKqFJuH;
                }
                string global::ExDawnOfDayTask.ResourceInfo.Resources.IDawnOfDayToast.RewardGp(object value)
                {
                    if (RewardGp__SeKqFJuH == null)
                        RewardGp__SeKqFJuH = new global::Opportunity.ResourceGenerator.FormattableResourceString(global::Opportunity.Helpers.Universal.LocalizedStrings.GetValue("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$RewardGp"));
                    return string.Format(RewardGp__SeKqFJuH.FormatString, value);
                }
                string global::ExDawnOfDayTask.ResourceInfo.Resources.IDawnOfDayToast.RewardGp(global::System.IFormatProvider provider, object value)
                {
                    if (RewardGp__SeKqFJuH == null)
                        RewardGp__SeKqFJuH = new global::Opportunity.ResourceGenerator.FormattableResourceString(global::Opportunity.Helpers.Universal.LocalizedStrings.GetValue("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$RewardGp"));
                    return string.Format(provider, RewardGp__SeKqFJuH.FormatString, value);
                }
                global::Opportunity.ResourceGenerator.FormattableResourceString RewardHath__cbkJNoMA;
                [global::Opportunity.ResourceGenerator.ResourcePathAttribute("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$RewardHath")]
                global::Opportunity.ResourceGenerator.FormattableResourceString global::ExDawnOfDayTask.ResourceInfo.Resources.IDawnOfDayToast.RewardHath()
                {
                    if (RewardHath__cbkJNoMA == null)
                        RewardHath__cbkJNoMA = new global::Opportunity.ResourceGenerator.FormattableResourceString(global::Opportunity.Helpers.Universal.LocalizedStrings.GetValue("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$RewardHath"));
                    return RewardHath__cbkJNoMA;
                }
                string global::ExDawnOfDayTask.ResourceInfo.Resources.IDawnOfDayToast.RewardHath(object value)
                {
                    if (RewardHath__cbkJNoMA == null)
                        RewardHath__cbkJNoMA = new global::Opportunity.ResourceGenerator.FormattableResourceString(global::Opportunity.Helpers.Universal.LocalizedStrings.GetValue("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$RewardHath"));
                    return string.Format(RewardHath__cbkJNoMA.FormatString, value);
                }
                string global::ExDawnOfDayTask.ResourceInfo.Resources.IDawnOfDayToast.RewardHath(global::System.IFormatProvider provider, object value)
                {
                    if (RewardHath__cbkJNoMA == null)
                        RewardHath__cbkJNoMA = new global::Opportunity.ResourceGenerator.FormattableResourceString(global::Opportunity.Helpers.Universal.LocalizedStrings.GetValue("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/$RewardHath"));
                    return string.Format(provider, RewardHath__cbkJNoMA.FormatString, value);
                }
                [global::Opportunity.ResourceGenerator.ResourcePathAttribute("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/Title")]
                string global::ExDawnOfDayTask.ResourceInfo.Resources.IDawnOfDayToast.Title
                    => global::Opportunity.Helpers.Universal.LocalizedStrings.GetValue("ms-resource:///ExDawnOfDayTask/Resources/DawnOfDayToast/Title");
            }

        }
    }
}
