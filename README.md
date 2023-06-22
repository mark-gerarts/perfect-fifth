# Perfect Fifth

[Homepage (with examples!)](https://mark-gerarts.github.io/perfect-fifth/)

Perfect Fifth is a Processing-like creative coding environment for F#. It is a
thin wrapper around [p5js](https://p5js.org), with some extra functional sugar
on top.

⚠️ All of the core p5.js library functions have been implemented, except those
under the [Data](https://p5js.org/reference/#group-Data) and
[IO](https://p5js.org/reference/#group-IO) namespaces. This is not due to a
technical limitation, but because of a lack of time/need. PRs are welcome!

## Installation

If you have not done so yet, set up a Fable project. More info can be found on
the [Fable site](https://fable.io/docs/2-steps/your-first-fable-project.html).

Add the NuGet package (in `src/`):

```bash
dotnet add package PerfectFifth --prerelease
```

⚠️ The Fable starter template is not 7.0-ready yet. When starting from this template, 
do the following as well: 

- set `<TargetFramework>net7.0</TargetFramework>` in your `App.fsproj`
- Target 7+ in `global.json` (e.g. `"version": "7.0.107"`).
- Target 7+ in `.config/dotnet-tools.json` (e.g. `"version": "4.0.0-theta-007"`)
- Run `dotnet tool restore` and `dotnet restore src`, applying any version mismatch warnings.

Make sure p5js is installed as a dependency:

```bash
npm i --save p5@^1.6.0
```

That's it! Take a look at the [usage](#usage) for the next steps.

## Examples

A part of the examples on the p5js site are ported to Perfect Fifth. You can
find the sketches and their source code on the [project
site](https://mark-gerarts.github.io/perfect-fifth/examples.html). The
[reference](https://mark-gerarts.github.io/perfect-fifth/reference.html)
contains function-specific examples.

## Usage

You can create a sketch in four different ways, depending on your use case:

- [`display`](#display) renders a single frame, without animation.
- [`animate`](#animate) creates an animation that updates itself based on time.
- [`simulate`](#simulate) creates a stateful simulation.
- [`play`](#play) creates a simulation that also handles input events.

These functions are a way to make life easier. If you want to use p5js directly,
take a look at [this section](#using-p5js-directly).

### Display

Using `display`, you can draw a single frame and nothing more.

```fsharp
// Definition:
let display
  (node: Node) // Element to render the canvas.
  (draw: P5 -> Unit) // Draw function that gets called a single time.
  : Unit = ...
```

The first argument is `node`, the target HTML element where the sketch should be
rendered. It can be set in three different ways:

```fsharp
type Node =
    // The query selector of an element.
    | Selector of string
    // A Fable Browser.Dom.Element, e.g. the result of document.querySelector
    | Element of Browser.Types.Element
    // Nothing. Create the canvas yourself in `draw` using `createCanvas`, or
    // let P5 handle it.
    | NoNode
```

The second argument is the draw function that will be called a single time. It
gets passed the `p5` context variable, which is needed for all p5 functionality.

For example:

```fsharp
module DrawExample

open Browser.Dom
open P5.Core
open P5.Rendering
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    resizeCanvas p5 720 400
    stroke p5 (Grayscale 255)

    let y = (height p5 |> float) * 0.5
    let width = width p5 |> float

    background p5 (Grayscale 0)
    line2D p5 0 y width y

display (Selector ".canvas-wrapper") draw

// Or
display (Element (document.querySelector ".canvas-wrapper")) draw

// Or
display NoNode draw
```

### Animate

`animate` is used to create an animation. Its `draw` function gets passed the
elapsed milliseconds since the start of the sketch.

```fsharp
// Definition:
let animate
    (node: Node) // Element to render the canvas.
    (setup: P5 -> Unit) // Setup function that gets called once, before the sketch starts.
    (draw: P5 -> int -> Unit) // Draw function that receives the time elapsed in ms.
  : Unit = ...
```

```fsharp
open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering

let setup p5 = createCanvas p5 100 100

let draw p5 t =
    background p5 (Grayscale 0)

    // Grow between radius 50 and 100 based on time passed.
    let size = 50 + ((t / 100) % 50)
    circle p5 50 50 size

animate NoNode setup draw
```

### Simulate

With `simulate` you can create a simulation that is able to update its state
every frame. The state can be any data type. For example, a simple counter can
use a single integer, while a complex simulation might use a big record type or
a class.

You provide an initial state in the setup function, which can then be updated
every step using the `update` function.

```fsharp
// Definition:
let simulate
    (node: Node) // Element to render the canvas.
    (setup: P5 -> 'a) // Setup function that gets called once, before the sketch starts. Returns the initial state.
    (update: P5 -> 'a -> 'a) // A function to step the state one iteration.
    (draw: P5 -> 'a -> Unit) // A function to draw something based on the current state.
    : Unit = ...
```

```fsharp
open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.Math

// The state can be anything. In this case it is a record,
// but scalars, tuples, classes, etc. work as well.
type State = { x: float; c: Color }

let setup p5 =
    createCanvas p5 100 100

    // Setup must return some initial state.
    { x = 0; c = (Grayscale 0) }

// Update receives the current state and returns the new one.
let update p5 state =
    let newX =
        match state.x + 1.0 with
        | 100.0 -> 0.0
        | x -> x

    // Switch colors every 10 steps.
    let newColor =
        match newX % 10.0 with
        | 0.0 -> RGB(randomBetween p5 0 255, randomBetween p5 0 255, randomBetween p5 0 255)
        | _ -> state.c

    { x = newX; c = newColor }

let draw p5 state =
    background p5 (Grayscale 0)
    fill p5 state.c
    square p5 state.x 50 20

let run node = simulate node setup update draw
```

### Play

Much the same as `simulate`, but `play` is able to handle input as well.

```fsharp
type EventHandler<'e, 'a> =
    // An event handler that only triggers side effects.
    | Effect of (P5 -> 'e -> Unit)
    // An event handler that updates the world state (and possibly triggers
    // side effects as well).
    | Update of (P5 -> 'e -> 'a -> 'a)

// A subscription binds an event type to an event handler.
type Subscription<'a> =
    | OnMouseMoved of EventHandler<MouseEvent, 'a>
    // ... and a lot more. See the reference.
    | OnWindowResized of EventHandler<UIEvent, 'a>
    // Recursive case that signals the default event should be prevented.
    | PreventDefault of Subscription<'a>

let play
    (node: Node) // Element to render the canvas.
    (setup: P5 -> 'a) // Setup function that gets called once, before the sketch starts. Returns the initial state.
    (update: P5 -> 'a -> 'a) // A function to step the state one iteration.
    (draw: P5 -> 'a -> Unit) // A function to draw something based on the current state.
    (subscriptions: Subscription<'a> list)// A list of subscriptions.
    : Unit = ...
```

```fsharp
module Example

open P5.Core
open P5.Shape
open P5.Color
open Browser.Types
open P5.Typography

type Shape =
    | Square
    | Circle

type State = { counter: int; shape: Shape }

// Set up the sketch and provide an initial state.
let setup p5 =
    createCanvas p5 100 100
    { counter = 0; shape = Circle } // Initial state.

// Update the state every render step.
let update p5 state =
    { state with counter = state.counter + 1 }

// Draw something based on the current state.
let draw p5 state =
    background p5 (Grayscale 51)

    match state.shape with
    | Circle -> circle p5 50 50 50
    | Square -> square p5 25 25 50

    text p5 (string state.counter) 40 15

// Alternate between square and circle when mouse is pressed. This is an event
// handler that updates the state.
let onMouseClicked p5 event state =
    let shape =
        match state.shape with
        | Circle -> Square
        | Square -> Circle

    { state with shape = shape }

// Multiple event handlers of the same type are perfectly possible. This one
// does not transform the state, and only has a side effect.
let onMouseClickedEff p5 event =
    let rand = System.Random()
    let r = rand.Next(0, 255)
    let g = rand.Next(0, 255)
    let b = rand.Next(0, 255)

    fill p5 (RGB(r, g, b))

// Event handlers get passed their respective JavaScript events (e.g.
// MouseEvent, UIEvent, ...).
let onMouseMoved p5 (event: MouseEvent) = printfn "%A" event.clientX

let subscriptions =
    [ OnMouseClicked(Update onMouseClicked)
      OnMouseClicked(Effect onMouseClickedEff)
      OnMouseMoved(Effect onMouseMoved) ]

play NoNode setup update draw subscriptions
```

In regular JavaScript p5js, you can return `false` from an event handler in
order to prevent the default event. E.g. returning `false` from `keyPressed`
would prevent normal keyboard shortcuts from working (F11, Ctrl+R, ...). In
Perfect Fifth, this is achieved by wrapping the subscription with
`PreventDefault`.

```fsharp
// Or equivalent: (PreventDefault (OnKeyPressed (Effect onKeyPressed)))
let subscriptions = [ Effect onKeyPressed |> OnKeyPressed |> PreventDefault ]
```

If there are multiple subscriptions registered for the same event, the
default event will be prevented if at least one of the subscriptions is wrapped
in `PreventDefault`.

### Using p5js Directly

Perfect Fifth is built with p5js' [instanced
mode](https://github.com/processing/p5.js/wiki/Global-and-instance-mode). If you
want full control, you can create a sketch using this underlying technique
directly.

```fsharp
let nodeElement = document.querySelector "some-selector"

let p5Sketch =
    // Inspired by https://github.com/aolney/fable-p5-demo
    new Func<obj, unit>(fun boxedP5 ->
        let p5 = unbox<P5> boxedP5

        p5.setup <-
            fun () -> resizeCanvas p5 200 200

        p5.draw <-
            fun () -> rect p5 10 10 10
    )

new P5(p5Sketch, nodeElement) |> ignore
```

## Preloading

If you need [preloading](https://p5js.org/reference/#/p5/preload), you can use
`drawWithPreload`, `simulateWithPreload`, or `playWithPreload`. The way these
work is as follows:

- The preload function returns some state
- This state gets passed to `setup`, which returns some other initial state
- `update` and `draw` work with this state

```fsharp
let simulateWithPreload
    (node: Node)
    (preload: P5 -> 'a)
    (setup: P5 -> 'a -> 'b)
    (update: P5 -> 'b -> 'b)
    (draw: P5 -> 'b -> Unit) = ...
```

For example:

```fsharp
open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering
open P5.Transform

let preload p5 =
    loadModel p5 "assets/octahedron.obj" false

let setup p5 octahedron =
    createWebGLCanvas p5 100 100
    (octahedron, 0.0)

let update p5 (octahedron, t) = (octahedron, t + 0.01)

let draw p5 (octahedron, t) =
    background p5 (Grayscale 200)
    rotateX p5 t
    rotateY p5 t
    model p5 octahedron

simulateWithPreload NoNode preload setup noUpdate draw
```

## Remarks

Some additional remarks, in no particular order.

- If you don't need a setup/update function, you can use the built-in functions
  `noSetup` (does no setup and returns Unit) and `noUpdate` (similar to `id`).
- The library is built using p5js in [instanced
  mode](https://github.com/processing/p5.js/wiki/Global-and-instance-mode). This
  is the reason why all functions require a p5 instance as an argument.
- The function naming scheme tries to mimic p5js as much as possible. However,
  p5js relies a lot on overloading, which is not possible in F#. Most overloads
  have different names in Perfect Fifth. E.g. `point(x, y, [z])` in p5js becomes
  `point2D p5 x y` and `point3D p5 x y z`. Check the
  [reference](https://mark-gerarts.github.io/perfect-fifth/reference.html) for a
  full overview.

## Tests

A basic test suite exists that simply checks every reference check to see if an
error is thrown. To use it, make sure the example site is running at port 8000:

```bash
$ pushd gh-pages && python -m venv venv && . venv/bin/active && pip install -r requirements.txt && popd
$ ./scripts/build-and-serve-site
```

Then run:

```bash
$ npm run test:e2e
```

## Credits

Inspired by [Haskell's Gloss](http://gloss.ouroborus.net/), [Clojure's
Quil](https://github.com/quil/quil), and [aolney's Fable P5
Demo](https://github.com/aolney/fable-p5-demo). Made possible with
[Fable](https://fable.io/) and [p5js](https://p5js.org).
