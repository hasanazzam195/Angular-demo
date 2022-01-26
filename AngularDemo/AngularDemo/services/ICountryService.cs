using AngularDemo.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularDemo.services
{
    public interface ICountryService
    {
        List<Country> LoadAll();
    }
}
