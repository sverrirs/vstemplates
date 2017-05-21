# Visual Studio Item Template Examples

This is a fully functional example project showing how to create a custom Item and Project template to use in Visual Studio 2012 and newer. 

The example also shows how to incorporate a custom Wizard that gets called after the traditional _Add New Item_ dialog and can be used to further enhance the template processing and resulting code generation.

For more information see my blog at:
https://blog.sverrirs.com/2017/05/vs-itemtemplates-wizards-and-vsix.html

## What the example contains

1. An Item template for a C++ unit test file. This template is installed into the _Add New Item_ dialog for all C++ projects.

<p align="center">
  <img src="https://raw.githubusercontent.com/sverrirs/vstemplates/master/img/add-new-item-dialog.png" />
</p>

2. A custom wizard that is called as a part of the _Add New Item_ process and is used to gather more detailed information to insert into the template.

<p align="center">
  <img src="https://raw.githubusercontent.com/sverrirs/vstemplates/master/img/wizard-dialog.png" />
</p>

3. A VSIX installer project that shows how to package the template project into a self contained automatic installer that can be used to target multiple versions of Visual Studio.

<p align="center">
  <img src="https://raw.githubusercontent.com/sverrirs/vstemplates/master/img/install.png" />
</p>

## Fix for "GetDeploymentPathFromVsixManifest" task failed unexpectedly
In some cases this error can crop up when debugging your installer and templates in an experimental version of Visual Studio. 

It is due to the existence of certain folders under your $APPDATA directories.

The solution includes a bat file `VSItemTemplateVISX\prebuild_clean.bat` that will remove all these unnecessary files for you in-case you encounter this error.

_You will have to shut down your Visual Studio instance before running the command_

### Details
The actual problem lies in the fact that Visual Studio locks the following three files 

```
privateregistry.bin
privateregistry.bin.LOG1
privateregistry.bin.LOG2
```

You can get away with just deleting them but removing the entire _Exp folder does no harm and potentially avoids other issues if you leave out of date Experimental files in there.