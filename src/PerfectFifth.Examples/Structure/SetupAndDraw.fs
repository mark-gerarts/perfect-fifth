module P5Examples.Structure.SetupAndDraw

open P5.Core
open P5.Rendering
open P5.Color
open P5.Environment
open P5.Shape

// Instead of global variables, Perfect Fifth allows you to use a state data
// type. This data type gets updated every frame using the `update` function.
type State = int

let setup p5 =
    resizeCanvas p5 720 400
    stroke p5 (Grayscale 255)

    // The intial state.
    0

let update p5 state =
    match state - 1 with
    | y when y < 0 -> height p5
    | y -> y

let draw p5 state =
    background p5 (Grayscale 0)
    line2D p5 0 (state |> float) (width p5) (state |> float)

let run node =
    simulate
        node // Target canvas wrapper
        setup // Function called once at startup
        update // Function that updates state every fraem
        draw // Function that draws something based on the state
