module P5Reference.Rendering.P5GraphicsReset

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering
open P5.Image
open P5.Transform

let setup p5 =
    background p5 (Grayscale 0)

    let pg = createGraphics p5 50 100
    fill pg (Grayscale 0)
    setFrameRate p5 5

    pg

let draw p5 pg =
    let width = width p5 |> float
    image p5 pg (width / 2.0) 0
    background pg (Grayscale 255)
    // p5.Graphics object behave a bit differently in some cases
    // The normal canvas on the left resets the translate
    // with every loop through draw()
    // the graphics object on the right doesn't automatically reset
    // so translate() is additive and it moves down the screen
    rect p5 0 0 (width / 2.0) 5
    rect pg 0 0 (width / 2.0) 5

    translateZ p5 0 5 0
    translateZ pg 0 5 0

let onMouseClicked p5 ev (pg: P5) =
    pg.reset ()
    pg

let subscriptions = [ OnMouseClicked(Update onMouseClicked) ]

let run node =
    play node setup noUpdate draw subscriptions
