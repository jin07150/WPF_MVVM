# WPF_MVVM
wpf mvvm with prism.unity nuget package

public class RibbonModuleMain : IModule // IModule --> Microsoft.Practices.Prism.Modularity ???
IRegionManager _regionManager;  // IRegionManger --> Microsoft.Practices.Prism.Regions ???
IUnitiyContainer _unityContainer; // IUnityContainer : IDisposabe 
                                  // IUnitiyContainer --> Microsft.Practices.Unity
                                  // IDisposable --> System.Runtime.InteropServices


var bootstraper = new SEQUSBootstrapper(); // ??
