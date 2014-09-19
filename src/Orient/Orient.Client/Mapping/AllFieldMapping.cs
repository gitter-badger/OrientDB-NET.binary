﻿using System;
using System.Collections.Generic;

namespace Orient.Client.Mapping
{
    internal class AllFieldMapping : FieldMapping
    {
        public AllFieldMapping() : base(null, null)
        {
        }

        public override void MapToObject(ODocument document, object typedObject, string basePath)
        {
            if (!string.IsNullOrEmpty(basePath))
                throw new NotSupportedException();

            var target = (ODocument) typedObject;
            foreach (KeyValuePair<string, object> item in document)
            {
                target.SetField(item.Key, item.Value);
            }
        }
    }
}