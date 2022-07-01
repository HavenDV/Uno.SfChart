// UWP does not support project level global usings.
global using System;
global using System.Linq;
global using System.Threading.Tasks;
global using System.Collections.Generic;

global using System.Globalization;
global using Windows.Foundation;

#if HAS_WINUI
global using Windows.UI;
global using Microsoft.UI;
global using Microsoft.UI.Input;
global using Microsoft.UI.Xaml;
global using Microsoft.UI.Xaml.Data;
global using Microsoft.UI.Xaml.Media;
global using Microsoft.UI.Xaml.Media.Imaging;
global using Microsoft.UI.Xaml.Media.Animation;
global using Microsoft.UI.Xaml.Input;
global using Microsoft.UI.Xaml.Markup;
global using Microsoft.UI.Xaml.Shapes;
global using Microsoft.UI.Xaml.Controls;
global using Microsoft.UI.Xaml.Controls.Primitives;
global using Microsoft.UI.Xaml.Documents;
global using Popup = Microsoft.UI.Xaml.Controls.Primitives.Popup;
global using WindowsLinesegment = Microsoft.UI.Xaml.Media.LineSegment;
global using WindowsLineSegment = Microsoft.UI.Xaml.Media.LineSegment;
global using Linesegment = Microsoft.UI.Xaml.Media.LineSegment;
global using BindableAttribute = Microsoft.UI.Xaml.Data.BindableAttribute;
global using PointerPoint = Microsoft.UI.Input.PointerPoint;
global using Colors = Microsoft.UI.Colors;
global using PointerDeviceType = Microsoft.UI.Input.PointerDeviceType;
#elif WINDOWS_PHONE
using System.Windows.Media.Imaging;
using System.Windows.Media;
#else
global using Windows.UI;
global using Windows.UI.Input;
global using Windows.UI.Xaml;
global using Windows.UI.Xaml.Data;
global using Windows.UI.Xaml.Media;
global using Windows.UI.Xaml.Media.Imaging;
global using Windows.UI.Xaml.Media.Animation;
global using Windows.UI.Xaml.Input;
global using Windows.UI.Xaml.Markup;
global using Windows.UI.Xaml.Shapes;
global using Windows.UI.Xaml.Controls;
global using Windows.UI.Xaml.Controls.Primitives;
global using Windows.UI.Xaml.Documents;
global using Popup = Windows.UI.Xaml.Controls.Primitives.Popup;
global using WindowsLinesegment = Windows.UI.Xaml.Media.LineSegment;
global using Linesegment = Windows.UI.Xaml.Media.LineSegment;
global using WindowsLineSegment = Windows.UI.Xaml.Media.LineSegment;
global using BindableAttribute = Windows.UI.Xaml.Data.BindableAttribute;
global using PointerPoint = Windows.UI.Input.PointerPoint;
global using Colors = Windows.UI.Colors;
global using PointerDeviceType = Windows.Devices.Input.PointerDeviceType;
#endif