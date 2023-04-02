module P5Reference.Events.WinMouseY

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering
open Browser
open P5.DOM
open P5.Events

let setup p5 =
    let canvas = createCanvasAndReturn p5 100 100
    let canvasEl = unbox<P5Element<'Unit>> canvas
    let body = document.querySelector "body"
    canvasEl.setParentFromNode body

    canvasEl

let draw p5 (canvas: P5Element<'Unit>) =
    background p5 (RGB(237, 34, 93))
    fill p5 (Grayscale 0)

    canvas.setPosition (float (windowWidth p5) / 2.0) (winMouseY p5 + 1.0)
    rect p5 (mouseX p5) 20 60 60

let run node = simulate node setup noUpdate draw
