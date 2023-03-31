module P5Reference.Events.AccelerationZ

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Events

let draw p5 t =
    let width = width p5 |> float
    let height = height p5 |> float

    background p5 (GrayscaleA(220, 50))
    fill p5 (Name "magenta")
    circle p5 (width / 2.0) (height / 2.0) (accelerationZ p5)

let run node = animate node noSetup draw
