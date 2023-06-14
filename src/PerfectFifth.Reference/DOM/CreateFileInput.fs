module P5Reference.DOM.CreateFileInput

open P5.Core
open P5.Color
open P5.Environment
open P5.DOM
open P5.Image

let mutable img = None

let setup p5 =
    let handleFile (file: P5File) =
        if file.fileType = "image" then
            do
                let newImg = createImg p5 (string file.data) ""
                newImg.hide ()
                img <- Some newImg
        else
            img <- None

    let input = createFileInput p5 handleFile
    input.setPosition 0 0

let draw p5 _ =
    background p5 (Grayscale 255)

    match img with
    | Some img -> imageWithSize p5 img 0 0 (width p5 |> float) (height p5 |> float)
    | None -> ()

let run node = animate node setup draw
