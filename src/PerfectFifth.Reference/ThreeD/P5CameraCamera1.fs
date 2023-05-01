module P5Reference.ThreeD.P5CameraCamera1

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.DOM
open P5.Rendering
open P5.Math
open P5.ThreeD

let setup p5 =
    let height = height p5 |> float
    createWebGLCanvas p5 100 100

    let sliders =
        Array.init 6 (fun i ->
            let slider =
                if i = 2 then
                    createSliderWithOptions p5 10 400 200 1
                else
                    createSliderWithOptions p5 -400 400 0 1

            let h = map p5 i 0 6 5 85
            slider.setPosition 10 (height + h)
            slider.style "width" "80px"
            slider)

    let cam = createCamera p5
    (sliders, cam)

let draw p5 (sliders: P5Element<float> array, cam: P5Camera) =
    background p5 (Grayscale 60)
    // assigning sliders' value to each parameters
    let X = sliders[ 0 ].getValue ()
    let Y = sliders[ 1 ].getValue ()
    let Z = sliders[ 2 ].getValue ()
    let centerX = sliders[ 3 ].getValue ()
    let centerY = sliders[ 4 ].getValue ()
    let centerZ = sliders[ 5 ].getValue ()
    cam.camera (X, Y, Z, centerX, centerY, centerZ, 0, 1, 0)
    stroke p5 (Grayscale 255)
    fill p5 (RGB(255, 102, 94))
    cube p5 85

let run node = simulate node setup noUpdate draw
