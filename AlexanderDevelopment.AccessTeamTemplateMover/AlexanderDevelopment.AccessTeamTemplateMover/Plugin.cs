﻿using System.ComponentModel.Composition;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace AlexanderDevelopment.AccessTeamTemplateMover
{
    [Export(typeof(IXrmToolBoxPlugin)),
    ExportMetadata("Name", "Access Team Template Mover"),
    ExportMetadata("Description", "Moves access team templates between Dynamics CRM organizations"),
    ExportMetadata("SmallImageBase64", "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"),
    ExportMetadata("BigImageBase64", "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"),
    ExportMetadata("BackgroundColor", "#dd550c"),
    ExportMetadata("PrimaryFontColor", "#03244d"),
    ExportMetadata("SecondaryFontColor", "#496e9c")]

    public class Plugin : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new AccessTeamTemplateMover();
        }
    }
}