module P5Reference.Image.Set1

open P5.Core
open P5.Color
open P5.Environment
open P5.Image

let draw p5 =
    let width = width p5 |> float
    let height = height p5 |> float

    for i in { 30.0 .. (width - 15.0) } do
        for j in { 20.0 .. (height - 25.0) } do
            let c = RGB(204.0 - j, 153.0 - i, 0)
            setPixel p5 i j c

    updatePixels p5

let run node = display node draw
