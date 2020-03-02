// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The source event types which evaluate the security automation set of
    /// rules. For example - security alerts and security assessments. To learn
    /// more about the supported security events data models schemas - please
    /// visit https://aka.ms/ASCAutomationSchemas.
    /// </summary>
    public partial class AutomationSource
    {
        /// <summary>
        /// Initializes a new instance of the AutomationSource class.
        /// </summary>
        public AutomationSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutomationSource class.
        /// </summary>
        /// <param name="eventSource">A valid event source type. Possible
        /// values include: 'Assessments', 'Alerts'</param>
        /// <param name="ruleSets">A set of rules which evaluate upon event
        /// interception. A logical disjunction is applied between defined rule
        /// sets (logical 'or').</param>
        public AutomationSource(string eventSource = default(string), IList<AutomationRuleSet> ruleSets = default(IList<AutomationRuleSet>))
        {
            EventSource = eventSource;
            RuleSets = ruleSets;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a valid event source type. Possible values include:
        /// 'Assessments', 'Alerts'
        /// </summary>
        [JsonProperty(PropertyName = "eventSource")]
        public string EventSource { get; set; }

        /// <summary>
        /// Gets or sets a set of rules which evaluate upon event interception.
        /// A logical disjunction is applied between defined rule sets (logical
        /// 'or').
        /// </summary>
        [JsonProperty(PropertyName = "ruleSets")]
        public IList<AutomationRuleSet> RuleSets { get; set; }

    }
}