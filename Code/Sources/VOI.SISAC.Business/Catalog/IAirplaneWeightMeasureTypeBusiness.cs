﻿//------------------------------------------------------------------------
// <copyright file="IAirplaneWeightMeasureTypeBusiness.cs" company="AACOSTA">
//     Copyright (c) http://aacosta.com.mx/ All rights reserved.
// </copyright>
//------------------------------------------------------------------

namespace VOI.SISAC.Business.Catalog
{
    using System.Collections.Generic;
    using VOI.SISAC.Business.Dto.Catalogs;

    /// <summary>
    /// Class IAirplane Weight Measure Type Business
    /// </summary>
    public interface IAirplaneWeightMeasureTypeBusiness
    {
        /// <summary>
        /// Gets the type of all airplane weight measure.
        /// </summary>
        /// <returns>IList AirplaneWeightMeasureTypeDto </returns>
        IList<AirplaneWeightMeasureTypeDto> GetAllAirplaneWeightMeasureType();
    }
}
