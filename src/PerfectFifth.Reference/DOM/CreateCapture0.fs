module P5Reference.DOM.CreateCapture0

open P5.Core
open P5.Environment
open P5.Rendering
open P5.DOM
open P5.Image

let setup p5 =
    createCanvas p5 100 100
    let capture = createCapture p5 "video"
    capture.hide ()
    capture

let draw p5 (capture: P5MediaElement) =
    let width = width p5 |> float

    imageWithSize p5 capture 0 0 width (width * capture.height / capture.width)
    filter p5 Invert

let run node = simulate node setup noUpdate draw
