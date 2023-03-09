module P5Reference.Environment.FrameRate

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

type State = { frameRate: int; x: int }

let setup p5 =
    background p5 (Grayscale 200)
    setFrameRate p5 30

    { frameRate = 30; x = 0 }

let update p5 state =
    let width = width p5
    let newX = state.x + 1

    if newX > width then
        let newFrameRate = if state.frameRate = 10 then 30 else 10

        { frameRate = newFrameRate; x = 0 }
    else
        { state with x = newX }


let draw p5 state =
    background p5 (Grayscale 200)

    // TODO: change this to a color class, like the p5js example.
    let color =
        match state.frameRate with
        | 10 -> RGB(0, 0, 255)
        | _ -> RGB(255, 0, 0)

    setFrameRate p5 state.frameRate
    fill p5 color
    square p5 state.x 40 20

let run node = simulate node setup update draw
