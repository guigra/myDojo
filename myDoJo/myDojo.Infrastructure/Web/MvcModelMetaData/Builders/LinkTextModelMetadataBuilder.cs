using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace myDojo.Infrastructure.Web.MvcModelMetaData.Builders
{
    public class LinkTextModelMetadataBuilder : IModelMetadataBuilder
    {
        public ModelMetadata BuildUp(ModelMetadata metadata, IEnumerable<Attribute> attributes, Type containerType, Func<object> modelAccessor, Type modelType, string propertyName)
        {
            var linkText = attributes.OfType<LinkText>().FirstOrDefault();
            if (linkText != null)
                metadata.AdditionalValues.Add("LinkText", linkText);
            return metadata;
        }
    }
}