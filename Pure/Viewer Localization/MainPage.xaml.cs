using System;
using System.Windows.Controls;
using Stimulsoft.Report;

namespace ViewerLocalization
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            #region Load Localizations
            var asm = System.Reflection.Assembly.GetExecutingAssembly();

            StiConfig.LoadLocalization(asm, "ViewerLocalization.Localization.ar.xml");
            StiConfig.LoadLocalization(asm, "ViewerLocalization.Localization.be.xml");
            StiConfig.LoadLocalization(asm, "ViewerLocalization.Localization.bg.xml");
            StiConfig.LoadLocalization(asm, "ViewerLocalization.Localization.cro.xml");
            StiConfig.LoadLocalization(asm, "ViewerLocalization.Localization.cz.xml");
            StiConfig.LoadLocalization(asm, "ViewerLocalization.Localization.de.xml");
            StiConfig.LoadLocalization(asm, "ViewerLocalization.Localization.en.xml");
            StiConfig.LoadLocalization(asm, "ViewerLocalization.Localization.es.xml");
            StiConfig.LoadLocalization(asm, "ViewerLocalization.Localization.fa.xml");
            StiConfig.LoadLocalization(asm, "ViewerLocalization.Localization.fr.xml");
            StiConfig.LoadLocalization(asm, "ViewerLocalization.Localization.hu.xml");
            StiConfig.LoadLocalization(asm, "ViewerLocalization.Localization.it.xml");
            StiConfig.LoadLocalization(asm, "ViewerLocalization.Localization.ka.xml");
            StiConfig.LoadLocalization(asm, "ViewerLocalization.Localization.lt.xml");
            StiConfig.LoadLocalization(asm, "ViewerLocalization.Localization.nl.xml");
            StiConfig.LoadLocalization(asm, "ViewerLocalization.Localization.pl.xml");
            StiConfig.LoadLocalization(asm, "ViewerLocalization.Localization.pt-BR.xml");
            StiConfig.LoadLocalization(asm, "ViewerLocalization.Localization.ro.xml");
            StiConfig.LoadLocalization(asm, "ViewerLocalization.Localization.ru.xml");
            StiConfig.LoadLocalization(asm, "ViewerLocalization.Localization.ser.xml");
            StiConfig.LoadLocalization(asm, "ViewerLocalization.Localization.sk.xml");
            StiConfig.LoadLocalization(asm, "ViewerLocalization.Localization.sv.xml");
            StiConfig.LoadLocalization(asm, "ViewerLocalization.Localization.tr.xml");
            StiConfig.LoadLocalization(asm, "ViewerLocalization.Localization.ua.xml");
            StiConfig.LoadLocalization(asm, "ViewerLocalization.Localization.zh-CHS.xml");
            StiConfig.LoadLocalization(asm, "ViewerLocalization.Localization.zh-CHT.xml");
            #endregion

            //!!!!
            StiSettings.Set("Localization", "Current", "de");

            InitializeComponent();
        }
    }
}