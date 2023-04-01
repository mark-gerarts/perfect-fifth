module P5Reference.Events.KeyIsDown0

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.Events

type Pos = { x: float; y: float }

let setup p5 =
    createCanvas p5 512 512
    fill p5 (RGB(255, 0, 0))
    { x = 100; y = 100 }

let update p5 pos =
    let incrementIfKeyIsDown key amount x =
        if keyCodeIsDown p5 key then x + amount else x

    let newX =
        pos.x
        |> incrementIfKeyIsDown LeftArrow -5.0
        |> incrementIfKeyIsDown RightArrow 5.0

    let newY =
        pos.y |> incrementIfKeyIsDown UpArrow -5.0 |> incrementIfKeyIsDown DownArrow 5.0

    { x = newX; y = newY }

let draw p5 pos =
    clear p5
    circle p5 pos.x pos.y 50

let run node = simulate node setup update draw
