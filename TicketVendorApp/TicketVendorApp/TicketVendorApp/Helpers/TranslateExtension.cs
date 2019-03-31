﻿using System;
using System.Reflection;
using System.Resources;
using Plugin.Multilingual;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TicketVendorApp.Helpers
{

    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        const string ResourceId = "TicketVendorApp.Resources.AppResources";

        static readonly Lazy<ResourceManager> resmgr =
            new Lazy<ResourceManager>(() =>
                new ResourceManager(ResourceId, typeof(TranslateExtension).GetTypeInfo().Assembly));

        public string Text { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Text == null)
                return "";

            var ci = CrossMultilingual.Current.CurrentCultureInfo;
            var translation = resmgr.Value.GetString(Text, ci);

            if (translation == null)
            {
                translation = Text; // returns the key, which GETS DISPLAYED TO THE USER
            }
            return translation;
        }
    }

}


