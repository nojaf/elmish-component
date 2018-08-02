# Elmish Component

A dotnet template to scaffold [Elmish subcomponents](https://elmish.github.io/elmish/parent-child.html).

## Install


[![NuGet](https://img.shields.io/nuget/vpre/Nuget.Core.svg?style=flat-square)](https://www.nuget.org/packages/Elmish.Component/0.1.0)

>dotnet new --install Elmish.Component

## Usage

Ex:

>dotnet new elmish-component -n Sunshine -na App -p TheSun

This create a folder named `Sunshine` with four files:

- Types.fs
```fsharp
module App.Sunshine.Types

type Model = 
    {
        Value: int
    }

type Msg = 
    | NoOp
```

- State.fs
```fsharp
module App.Sunshine.State

open Elmish
open App.Sunshine.Types
let init _ =
    { Value = 0}, Cmd.none

let update msg model =
    match msg with
    | NoOp ->
        model, Cmd.none    
```
- View.fs
```fsharp
module Namespace.Sunshine.State

open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Core.JsInterop
open Fable.Import
open App.Sunshine.Types

let view model dispatch =
    div [] [ 
        h1 [] [str "Sunshine view"]
        p [] [
            str "Model"
            strong [] [sprintf "%A" model |> str]
            button [OnClick (fun _ -> dispatch NoOp) ] [
                str "Click me"
            ]
        ]
    ]
```
- temp.txt

Bits of code that fit into the main Elmish Program.
```
// Types.fs

| SunshineMsg of App.Sunshine.Types.Msg

// State.fs

/// init
let initSunshine, SunshineCmd = App.Sunshine.State.init ()

TheSun = initSunshine
...
Cmd.map SunshineMsg SunshineCmd

/// update

| SunshineMsg msg ->
    let m,c = App.Sunshine.State.update msg model.TheSun
    { model with TheSun = m}, Cmd.map SunshineMsg c

// fsproj

    <Compile Include="Sunshine\Types.fs" />
    <Compile Include="Sunshine\State.fs" />
    <Compile Include="Sunshine\View.fs" />
```

See `sample`.