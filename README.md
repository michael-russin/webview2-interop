<img src="https://github.com/michael-russin/webview2-interop/blob/master/new-microsoft-edge-icon.png" width="96">

# webview2-interop
Interop and C# wrapper classes for Microsoft WebView2 web browser control

When Microsoft revealed their plans for a Chrome based Edge browser the first thing I thought was "I wonder if they are going to support an embedded web browser control"?  Well sure enough they released [WebView2](https://github.com/MicrosoftEdge/WebView2Browser) and I've been keeping an eye on the releases.  Recently I found a great [sample](https://github.com/MicrosoftEdge/WebView2Browser) written by [David Risney](https://github.com/david-risney) and I was inspired to take a shot at putting together a C# version. 

This project contains interop code for the WebView2.  Most of it has been modified from what you get from the standard tlbimp command.  Besides the interop classes which match the [WebView2 interface](https://docs.microsoft.com/en-us/microsoft-edge/hosting/webview2/reference-webview2) closely there are also some wrapper classes around the interfaces available.  They try to take some of the patterns used and hopefully make them a little more C# friendly.   For example the add/remove methods with interface callbacks have been changed to Register/Unregister that take Actions with event arguments.  

Finally if you're looking for a Windows Forms control you can just drag and drop in the designer take a look at another project based off this [WebView2 Windows Forms control](https://github.com/michael-russin/webview2-control)

## Installing / Getting started

* Microsoft Edge (Chromium) installed on a supported OS.
* Visual Stdio 2017 or 2019 with C# and desktop development set up

### Initial Configuration

Some projects require initial configuration (e.g. access tokens or keys, `npm i`).
This is the section where you would document those requirements.

## Features

* Interop classes for the WebView2
* Wrapper classes around WebView2 interfaces

Checked [here](./implemented.md) to see what is implemented and working.

## Contributing

If you'd like to contribute, please fork the repository and use a feature
branch. Pull requests are warmly welcome.

## Links
- Project homepage: https://github.com/michael-russin/webview2-interop
- Repository: https://github.com/michael-russin/webview2-interop
- Issue tracker: https://github.com/michael-russin/webview2-interop/issues
- Related projects:
  - WebView2 Windows Forms Control: https://github.com/michael-russin/webview2-control
  - David's awsome C++ sample: https://github.com/MicrosoftEdge/WebView2Browser
  - WebView2 Documentation: https://docs.microsoft.com/en-us/microsoft-edge/hosting/webview2/reference-webview2


## Licensing

The code in this project is licensed under MIT license.
