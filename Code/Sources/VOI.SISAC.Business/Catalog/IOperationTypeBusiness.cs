﻿//------------------------------------------------------------------------
// <copyright file="IOperationTypeBusiness.cs" company="Volaris">
//     Copyright (c) Volaris. All rights reserved.
// </copyright>
//---------------------------------------------------------------------

namespace VOI.SISAC.Business.Catalog
{
    using System.Collections.Generic;
    using VOI.SISAC.Business.Dto.Catalogs;

    /// <summary>
    /// Interface Operation Type Business
    /// </summary>
    public interface IOperationTypeBusiness
    {
        /// <summary>
        /// Gets the type of all operation.
        /// </summary>
        /// <returns>IList OperationTypeDto</returns>
        IList<OperationTypeDto> GetAllOperationType();
    }
}
