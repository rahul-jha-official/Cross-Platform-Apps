# .NET MAUI
.NET Multi-platform App UI (.NET MAUI) is a cross-platform framework for creating native mobile and desktop apps with C# and XAML.

Using .NET MAUI, you can develop apps that can run on Android, iOS, macOS, and Windows from a single shared code-base.

![image](https://github.com/user-attachments/assets/a3538352-4e25-482e-9685-2d5e136e531d)

.NET MAUI is open-source and is the evolution of Xamarin.Forms, extended from mobile to desktop scenarios, with UI controls rebuilt from the ground up for performance and extensibility. If you've previously used Xamarin.Forms to build cross-platform user interfaces, you'll notice many similarities with .NET MAUI. However, there are also some differences. Using .NET MAUI, you can create multi-platform apps using a single project, but you can add platform-specific source code and resources if necessary. One of the key aims of .NET MAUI is to enable you to implement as much of your app logic and UI layout as possible in a single code-base.

# How .NET MAUI works ?
.NET MAUI unifies Android, iOS, macOS, and Windows APIs into a single API that allows a write-once run-anywhere developer experience, while additionally providing deep access to every aspect of each native platform.

.NET 6 or greater provides a series of platform-specific frameworks for creating apps: .NET for Android, .NET for iOS, .NET for Mac Catalyst, and Windows UI 3 (WinUI 3) library. These frameworks all have access to the same .NET Base Class Library (BCL). This library abstracts the details of the underlying platform away from your code. The BCL depends on the .NET runtime to provide the execution environment for your code. For Android, iOS, and macOS, the environment is implemented by Mono, an implementation of the .NET runtime. On Windows, .NET CoreCLR provides the execution environment.

While the BCL enables apps running on different platforms to share common business logic, the various platforms have different ways of defining the user interface for an app, and they provide varying models for specifying how the elements of a user interface communicate and interoperate. You can craft the UI for each platform separately using the appropriate platform-specific framework (.NET for Android, .NET for iOS, .NET for Mac Catalyst, or WinUI 3), but this approach then requires you to maintain a code-base for each individual family of devices.

.NET MAUI provides a single framework for building the UIs for mobile and desktop apps. The following diagram shows a high-level view of the architecture of a .NET MAUI app:

![image](https://github.com/user-attachments/assets/de0ad000-189a-4f52-a3e4-76c1f01a7214)

In a .NET MAUI app, you write code that primarily interacts with the .NET MAUI controls and API layer (1). This layer then directly consumes the native platform APIs (3). In addition, app code may directly exercise platform APIs (2), if required.

.NET MAUI apps can be written on PC or Mac, and compile into native app packages:
- Android apps built using .NET MAUI compile from C# into an intermediate language (IL) which is then just-in-time (JIT) compiled to a native assembly when the app launches.
- iOS apps built using .NET MAUI are fully ahead-of-time (AOT) compiled from C# into native ARM assembly code.
- macOS apps built using .NET MAUI use Mac Catalyst, a solution from Apple that brings your iOS app built with UIKit to the desktop, and augments it with additional AppKit and platform APIs as required.
- Windows apps built using .NET MAUI use Windows UI 3 (WinUI 3) library to create native apps that target the Windows desktop. For more information about WinUI 3, see Windows UI Library.

# What .NET MAUI provides ?
.NET MAUI provides a collection of controls that can be used to display data, initiate actions, indicate activity, display collections, pick data, and more. In addition to a collection of controls, .NET MAUI also provides:
- An elaborate layout engine for designing pages.
- Multiple page types for creating rich navigation types, like drawers.
- Support for data-binding, for more elegant and maintainable development patterns.
- The ability to customize handlers to enhance the way in which UI elements are presented.
- Cross-platform APIs for accessing native device features. These APIs enable apps to access device features such as the GPS, the accelerometer, and battery and network states. For more information, see Cross-platform APIs for device features.
- Cross-platform graphics functionality, that provides a drawing canvas that supports drawing and painting shapes and images, compositing operations, and graphical object transforms.
- A single project system that uses multi-targeting to target Android, iOS, macOS, and Windows. For more information, see .NET MAUI Single project.
- .NET hot reload, so that you can modify both your XAML and your managed source code while the app is running, then observe the result of your modifications without rebuilding the app. For more information, see .NET hot reload.

# XAML
The eXtensible Application Markup Language (XAML) is an XML-based language that's an alternative to programming code for instantiating and initializing objects, and organizing those objects in parent-child hierarchies.

XAML allows developers to define user interfaces in .NET Multi-platform App UI (.NET MAUI) apps using markup rather than code. XAML is not required in a .NET MAUI app, but it is the recommended approach to developing your UI because it's often more succinct, more visually coherent, and has tooling support. XAML is also well suited for use with the Model-View-ViewModel (MVVM) pattern, where XAML defines the view that is linked to viewmodel code through XAML-based data bindings.

Within a XAML file, you can define user interfaces using all the .NET MAUI views, layouts, and pages, as well as custom classes. The XAML file can be either compiled or embedded in the app package. Either way, the XAML is parsed at build time to locate named objects, and at runtime the objects represented by the XAML are instantiated and initialized.

XAML has several advantages over equivalent code:
- XAML is often more succinct and readable than equivalent code.
- The parent-child hierarchy inherent in XML allows XAML to mimic with greater visual clarity the parent-child hierarchy of user-interface objects.

There are also disadvantages, mostly related to limitations that are intrinsic to markup languages:
- XAML cannot contain code. All event handlers must be defined in a code file.
- XAML cannot contain loops for repetitive processing. However there are controls that display collections of data, such as ListView and CollectionView.
- XAML cannot contain conditional processing. However, a data-binding can reference a code-based binding converter that effectively allows some conditional processing.
- XAML generally cannot instantiate classes that do not define a parameterless constructor, although this restriction can sometimes be overcome.
- XAML generally cannot call methods, although this restriction can sometimes be overcome.

XAML is basically XML, but XAML has some unique syntax features. The most important are:
- Property elements
- Attached properties
- Markup extensions

