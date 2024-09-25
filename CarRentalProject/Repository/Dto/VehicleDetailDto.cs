using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalProject.Repository.Dto;

public record VehicleDetailDto
    (
    int Id,
    string FuelName,
    string TransmissionType,
    string ColorName,
    string CarState,
    int? Kilometer,
    short? ModelYear,
    string Plate,
    string BrandName,
    string ModelName,
    double? DailyPrice
    );

