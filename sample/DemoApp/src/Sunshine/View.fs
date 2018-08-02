module App.Sunshine.View

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
            br []
            button [OnClick (fun _ -> dispatch NoOp) ] [
                str "Click me"
            ]
        ]
    ]