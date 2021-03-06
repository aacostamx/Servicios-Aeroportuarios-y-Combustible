﻿//------------------------------------------------------------------------
// <copyright file="PageReportVO.cs" company="AACOSTA">
//     Copyright (c) http://aacosta.com.mx/ All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace VOI.SISAC.Web.Models.VO.Security
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Accounting Account VO
    /// </summary>
    public class PageReportVO
    {
        // <summary>
        /// Gets or sets the PageName.
        /// Primary key.
        /// </summary>
        /// <value>
        /// The PageName.
        /// </value>
        public string PageName { get; set; }

        // <summary>
        /// Gets or sets the PathReport.
        /// </summary>
        /// <value>
        /// The PathReport.
        /// </value>
        public string PathReport { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="AccountingAccount"/> is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if active; otherwise, <c>false</c>.
        /// </value>
        public bool Status { get; set; }
    }
}