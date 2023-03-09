module P5Reference.Environment.GetTargetFrameRate

open P5.Core
open P5.Typography
open P5.Color
open P5.Environment

let draw p5 t =
    let centerX = (width p5 |> float) / 2.0
    let centerY = (height p5 |> float) / 2.0

    setFrameRate p5 20
    text p5 (getTargetFrameRate p5 |> string) centerX centerY

let run node = animate node noSetup draw
