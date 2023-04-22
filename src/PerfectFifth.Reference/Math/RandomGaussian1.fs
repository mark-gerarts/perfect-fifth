module P5Reference.Math.RandomGaussian1

open P5.Core
open P5.Color
open P5.Shape
open P5.Math
open P5.Rendering
open P5.Transform
open P5.Environment

let setup p5 =
    createCanvas p5 100 100

    Array.init 360 (fun _ -> randomGaussianFromMeanAndSd p5 0 15 |> floor)


let draw p5 distribution =
    background p5 (Grayscale 204)
    translate p5 (width p5 / 2 |> float) (width p5 / 2 |> float)

    let drawLine l =
        rotate p5 (twoPi / 360.0)
        stroke p5 (Grayscale 0)
        line p5 0 0 (abs l) 0

    Array.iter drawLine distribution

let run node = simulate node setup noUpdate draw
