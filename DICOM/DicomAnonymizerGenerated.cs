﻿// Copyright (c) 2012-2019 fo-dicom contributors.
// Licensed under the Microsoft Public License (MS-PL).

namespace Dicom
{
    public partial class DicomAnonymizer
    {
        public partial class SecurityProfile
        {
            /// <summary>
            /// De-identification map taken from DICOM PS 3.15: http://dicom.nema.org/medical/dicom/current/output/chtml/part15/PS3.15.html
            /// </summary>
            /// <remarks>
            /// The CSV columns are:
            /// - Tag (regex)
            /// - BasicProfile
            /// - RetainSafePrivateOption
            /// - RetainUIDsOption
            /// - RetainDeviceIdentOption
            /// - RetainPatientCharsOption
            /// - RetainLongFullDatesOption
            /// - RetainLongModifDatesOption
            /// - CleanDescOption
            /// - CleanStructdContOption
            /// - CleanGraphOption
            /// </remarks>
            private const string DefaultProfile = @"
                [0-9A-F]{3}[13579BDF],[0-9A-F]{4};X;C;;;;;;;;
                50[0-9A-F]{2},[0-9A-F]{4};X;;;;;;;;;C
                60[0-9A-F]{2},4000;X;;;;;;;;;C
                60[0-9A-F]{2},3000;X;;;;;;;;;C                
			";
        }
    }
}
