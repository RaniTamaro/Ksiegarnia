using AutoMapper;
using Firma.Models.Entities;
using Firma.Models.EntitiesForSpecialView;
using Firma.Models.EntitiesForView;
using Firma.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Firma
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IMapper _mapper;

        public App()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<PozycjaFakturyForSpecialView, PozycjaFaktury>()
                    .ForAllMembers(opt => opt.Condition((src, dest, srcMember) => !(srcMember is EntityReference)));

                cfg.CreateMap<PozycjaMagazynuForSpecialView, PozycjaMagazynu>()
                    .ForAllMembers(opt => opt.Condition((src, dest, srcMember) => !(srcMember is EntityReference)));

                cfg.CreateMap<PozycjaMagazynu, PozycjaMagazynuForSpecialView>();
                cfg.CreateMap<PozycjaFaktury, PozycjaFakturyForSpecialView>();
                cfg.CreateMap<TowaryForAllView, PozycjaMagazynuForSpecialView>();
                cfg.CreateMap<TowaryForAllView, PozycjaFakturyForSpecialView>();
            });

            _mapper = config.CreateMapper();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow window = new MainWindow();
            window.DataContext = new MainWindowViewModel(_mapper);
            window.Show();

        }
    }
}
