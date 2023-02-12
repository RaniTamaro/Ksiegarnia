using AutoMapper;
using Firma.Models.EntitiesForView;
using Firma.ViewModels.Abstract;
using Firma.ViewResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModels
{
    internal class WydanieViewModel : NowaAkcjaMagazynowaViewModel
    {
        #region Kontruktor

        public WydanieViewModel(IMapper mapper)
            : base(GlobalResources.Wydanie, mapper)
        {
            _mapper = mapper;
        }
        #endregion
        #region Properties
        private readonly IMapper _mapper;
        public override IQueryable<KeyAndValue> RodzajDokumentuComboboxItems
        {
            get
            {
                return Db.RodzajDokumentu
                    .Where(x => x.CzyAktywny == true && x.Kod.StartsWith("W"))
                    .Select(rodzaj =>
                        new KeyAndValue
                        {
                            Key = rodzaj.IdRodzajuDokumentu,
                            Value = rodzaj.Kod
                        }
                    ).ToList().AsQueryable();
            }
        }
        #endregion
    }
}
