using AutoMapper;
using Firma.Helpers;
using Firma.Models.Entities;
using Firma.Models.EntitiesForView;
using Firma.ViewModels.Abstract;
using Firma.ViewResources;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Firma.ViewModels
{
    internal class PrzyjecieViewModel : NowaAkcjaMagazynowaViewModel
    {
        #region Konstruktor

        public PrzyjecieViewModel(IMapper mapper)
            : base(GlobalResources.Przyjęcie, mapper)
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
                    .Where(x => x.CzyAktywny == true && x.Kod.StartsWith("P"))
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
