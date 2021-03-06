// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Management.Resources.Models
{
    /// <summary> Entity representing the reference to the template. </summary>
    public partial class TemplateLink
    {
        /// <summary> Initializes a new instance of TemplateLink. </summary>
        /// <param name="uri"> The URI of the template to deploy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        public TemplateLink(string uri)
        {
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }

            Uri = uri;
        }

        /// <summary> Initializes a new instance of TemplateLink. </summary>
        /// <param name="uri"> The URI of the template to deploy. </param>
        /// <param name="contentVersion"> If included, must match the ContentVersion in the template. </param>
        internal TemplateLink(string uri, string contentVersion)
        {
            Uri = uri;
            ContentVersion = contentVersion;
        }

        /// <summary> The URI of the template to deploy. </summary>
        public string Uri { get; set; }
        /// <summary> If included, must match the ContentVersion in the template. </summary>
        public string ContentVersion { get; set; }
    }
}
