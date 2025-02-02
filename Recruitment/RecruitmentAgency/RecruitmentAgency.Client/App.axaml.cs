using AutoMapper;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using RecruitmentAgency.Client.ViewModels;
using RecruitmentAgency.Client.Views;
using Splat;

namespace RecruitmentAgency.Client;
public partial class App : Application
{
    public static Window MainWindow { get; set; }
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<CompanyGetDto, CompanyViewModel>();
                    cfg.CreateMap<CompanyViewModel, CompanyGetDto>();
                    cfg.CreateMap<CompanyPostDto, CompanyViewModel>();
                    cfg.CreateMap<CompanyViewModel, CompanyPostDto>();

                    cfg.CreateMap<CompanyApplicationGetDto, CompanyApplicationViewModel>()
        .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date.DateTime));
                    cfg.CreateMap<CompanyApplicationViewModel, CompanyApplicationGetDto>();
                    cfg.CreateMap<CompanyApplicationPostDto, CompanyApplicationViewModel>();
                    cfg.CreateMap<CompanyApplicationViewModel, CompanyApplicationPostDto>();
                    cfg.CreateMap<CompanyApplication, CompanyApplicationViewModel>();
                    cfg.CreateMap<CompanyApplicationViewModel, CompanyApplication>();

                    cfg.CreateMap<EmployeeGetDto, EmployeeViewModel>();
                    cfg.CreateMap<EmployeeViewModel, EmployeeGetDto>();
                    cfg.CreateMap<EmployeePostDto, EmployeeViewModel>();
                    cfg.CreateMap<EmployeeViewModel, EmployeePostDto>();

                    cfg.CreateMap<JobApplicationGetDto, JobApplicationViewModel>()
                    .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date.DateTime));
                    cfg.CreateMap<JobApplicationViewModel, JobApplicationGetDto>();
                    cfg.CreateMap<JobApplicationPostDto, JobApplicationViewModel>();
                    cfg.CreateMap<JobApplicationViewModel, JobApplicationPostDto>();

                    cfg.CreateMap<TitleGetDto, TitleViewModel>();
                    cfg.CreateMap<TitleViewModel, TitleGetDto>();
                    cfg.CreateMap<TitlePostDto, TitleViewModel>();
                    cfg.CreateMap<TitleViewModel, TitlePostDto>();

                }
            );
            Locator.CurrentMutable.RegisterConstant(new ApiWrapper());
            Locator.CurrentMutable.RegisterConstant(config.CreateMapper(), typeof(IMapper));
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel(),
            };
            App.MainWindow = desktop.MainWindow;
        }

        base.OnFrameworkInitializationCompleted();
    }
}