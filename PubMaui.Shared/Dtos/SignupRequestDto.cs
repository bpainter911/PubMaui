﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubMaui.Shared.Dtos
{
    public record SignupRequestDto(string FullName, string Email, string Password, string FirstName, string LastName, string PhNumber, string Address, string CityTown, string PostalCode);

}
