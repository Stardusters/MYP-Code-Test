using System.ComponentModel;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace EngineerTest;

public class Pharmacy : IPharmacy
{
    private readonly IDrug[] _drugs;
    //private readonly List<IDrug> _lstDrugs;

    public Pharmacy(IEnumerable<IDrug> drugs)
    {
        _drugs = drugs.ToArray();
        //_lstDrugs = drugs.ToList();
    }

    public IEnumerable<IDrug> UpdateBenefitValue()
    {
        foreach(var item in _drugs)
        {
            if(item.Name != "Magic Pill")
            {
                item.ExpiresIn -= 1;
            }

            if(item.ExpiresIn > 10)
            {
                switch (item.Name)
                {
                    case "Herbal Tea": item.Benefit += 1; break;
                    case "Fervex": item.Benefit += 1; break;
                    case "Doliprane": item.Benefit -= 1; break;
                    case "Dafalgan": item.Benefit -= 2; break;
                    default: break;
                }
            }
            else if(item.ExpiresIn > 5)
            {
                switch (item.Name)
                {
                    case "Herbal Tea":  item.Benefit += 1; break;
                    case "Fervex":  item.Benefit += 2; break;
                    case "Doliprane": item.Benefit -= 1; break;
                    case "Dafalgan": item.Benefit -= 2; break;
                    default: break;
                }
            }
            else if(item.ExpiresIn > 0)
            {
                switch (item.Name)
                {
                    case "Herbal Tea": item.Benefit += 1; break;
                    case "Fervex": item.Benefit += 3; break;
                    case "Doliprane": item.Benefit -= 1; break;
                    case "Dafalgan": item.Benefit -= 2; break;
                    default: break;
                }
            }
            else
            {
                switch (item.Name)
                {
                    case "Herbal Tea": item.Benefit += 2; break;
                    case "Fervex": item.Benefit = 0; break;
                    case "Doliprane": item.Benefit -= 2; break;
                    case "Dafalgan": item.Benefit -= 4; break;
                    default: break;
                }
            }

            if(item.Benefit < 0)
            {
                item.Benefit = 0;
            }
        }
        return _drugs; ;

        //for (var i = 0; i < _drugs.Length; i++)
        //{
        //    if (
        //        _drugs[i].Name != "Herbal Tea" &&
        //        _drugs[i].Name != "Fervex"
        //    )
        //    {
        //        if (_drugs[i].Benefit > 0)
        //        {
        //            if (_drugs[i].Name != "Magic Pill")
        //            {
        //                _drugs[i].Benefit = _drugs[i].Benefit - 1;
        //            }
        //            if (_drugs[i].Name == "Dafalgan")
        //            {
        //                _drugs[i].Benefit = _drugs[i].Benefit - 1;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        if (_drugs[i].Benefit < 50)
        //        {
        //            _drugs[i].Benefit = _drugs[i].Benefit + 1;
        //            if (_drugs[i].Name == "Fervex")
        //            {
        //                if (_drugs[i].ExpiresIn < 11)
        //                {
        //                    if (_drugs[i].Benefit < 50)
        //                    {
        //                        _drugs[i].Benefit = _drugs[i].Benefit + 1;
        //                    }
        //                }

        //                if (_drugs[i].ExpiresIn < 6)
        //                {
        //                    if (_drugs[i].Benefit < 50)
        //                    {
        //                        _drugs[i].Benefit = _drugs[i].Benefit + 1;
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    if (_drugs[i].Name != "Magic Pill")
        //    {
        //        _drugs[i].ExpiresIn = _drugs[i].ExpiresIn - 1;
        //    }

        //    if (_drugs[i].ExpiresIn < 0)
        //    {
        //        if (_drugs[i].Name != "Herbal Tea")
        //        {
        //            if (_drugs[i].Name != "Fervex")
        //            {
        //                if (_drugs[i].Benefit > 0)
        //                {
        //                    if (_drugs[i].Name != "Magic Pill")
        //                    {
        //                        if (_drugs[i].Name != "Dafalgan")
        //                        {
        //                            _drugs[i].Benefit = _drugs[i].Benefit - 1;
        //                        }
        //                        else
        //                        {
        //                            _drugs[i].Benefit = _drugs[i].Benefit - 2;
        //                        }

        //                    }
        //                }
        //            }
        //            else
        //            {
        //                _drugs[i].Benefit =
        //                    _drugs[i].Benefit - _drugs[i].Benefit;
        //            }
        //        }
        //        else
        //        {
        //            if (_drugs[i].Benefit < 50)
        //            {
        //                _drugs[i].Benefit = _drugs[i].Benefit + 1;
        //            }
        //        }
        //    }

        //    if (_drugs[i].Benefit < 0)
        //    {
        //        _drugs[i].Benefit = 0;
        //    }
        //}

        //return _drugs;
    }
}