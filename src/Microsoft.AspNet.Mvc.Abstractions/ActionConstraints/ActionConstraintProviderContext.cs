// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc.Abstractions;

namespace Microsoft.AspNet.Mvc.ActionConstraints
{
    /// <summary>
    /// Context for an action constraint provider.
    /// </summary>
    public class ActionConstraintProviderContext
    {
        /// <summary>
        /// Creates a new <see cref="ActionConstraintProviderContext"/>.
        /// </summary>
        /// <param name="action">The <see cref="ActionDescriptor"/> for which constraints are being created.</param>
        /// <param name="items">The list of <see cref="ActionConstraintItem"/> objects.</param>
        public ActionConstraintProviderContext(
            HttpContext context,
            ActionDescriptor action,
            IList<ActionConstraintItem> items)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            if (items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            HttpContext = context;
            Action = action;
            Results = items;
        }

        public HttpContext HttpContext { get; }

        /// <summary>
        /// The <see cref="ActionDescriptor"/> for which constraints are being created.
        /// </summary>
        public ActionDescriptor Action { get; private set; }

        /// <summary>
        /// The list of <see cref="ActionConstraintItem"/> objects.
        /// </summary>
        public IList<ActionConstraintItem> Results { get; private set; }
    }
}