# Visual Studio Item Template Examples

This is a fully functional example project showing how to create a custom Item and Project template to use in Visual Studio 2012 and newer. 

The example also shows how to incorporate a custom Wizard that gets called after the traditional "Add Item" dialog and can be used to further enhance the template processing and resulting code generation.

For more information see my blog at:
https://blog.sverrirs.com/

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
