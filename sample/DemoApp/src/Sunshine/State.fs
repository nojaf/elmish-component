module App.Sunshine.State

open Elmish
open App.Sunshine.Types
let init _ =
    { Value = 0}, Cmd.none

let update msg model =
    match msg with
    | NoOp ->
        model, Cmd.none    