//-----------------------------------------------------------------------
// <copyright>
//     This Source Code Form is subject to the terms of the Mozilla Public
//     License, v. 2.0. If a copy of the MPL was not distributed with this
//     file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
//-----------------------------------------------------------------------

namespace NewPointe.JitBit.Structures
{

    public class CustomFieldValue
    {
                string Value { get; set; }
                int? OptionID { get; set; }
                string FieldName { get; set; }
                int FieldID { get; set; }
                CustomFieldType Type { get; set; }
                int UsageType { get; set; }
                int AccessType { get; set; }
                bool Mandatory { get; set; }
                int OrderByNumber { get; set; }
                bool ShowInGrid { get; set; }
                dynamic SelectionComboOptions { get; set; }
    }
}