module ProjectNamespace.ElmishComponent.State

open Elmish
open ProjectNamespace.ElmishComponent.Types

let init _ =
    { Value = 0}, Cmd.none

let update msg model =
    match msg with
    | NoOp ->
        model, Cmd.none    