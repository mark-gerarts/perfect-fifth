module P5Examples.Simulate.Flocking

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.Math
open P5.Structure
open P5.Transform
open P5.Environment
open P5.Events

// Original source: https://p5js.org/examples/simulate-flocking.html
//
// This is a heavy object-oriented implementation, to follow the original
// example as close as possible.

type Boid(x, y) =
    let randomFloat () =
        (System.Random().Next(-1000, 1000) |> float) / 1000.0

    let _acceleration = P5Vector.create (0, 0)
    let _velocity = P5Vector.create (randomFloat (), randomFloat ())
    let _position = P5Vector.create (x, y)
    let r = 3.0
    let maxSpeed = 3.0
    let maxForce = 0.05

    member _.position
        with private get () = _position

    member _.velocity
        with private get () = _velocity

    member self.run (p5: P5) (boids: Boid list) =
        self.flock boids
        self.update ()
        self.borders (p5)
        self.render (p5)

    member private _.applyForce(f: P5Vector) = _acceleration.addVector f

    member private self.flock(boids: Boid list) =
        let sep = self.separate boids
        let ali = self.align boids
        let coh = self.cohesion boids
        // Arbitrarily weight these forces
        sep.multScalar 1.5
        ali.multScalar 1.0
        coh.multScalar 1.0
        // Add the force vectors to acceleration
        self.applyForce sep
        self.applyForce ali
        self.applyForce coh

    member private _.update() =
        _velocity.addVector _acceleration
        _velocity.limit maxSpeed
        _position.addVector _velocity
        _acceleration.multScalar 0

    member private _.seek(target: P5Vector) : P5Vector =
        let desired = P5Vector.sub (target, _position) // A vector pointing from the location to the target
        // Normalize desired and scale to maximum speed
        desired.normalize ()
        desired.multScalar maxSpeed
        // Steering = Desired minus Velocity
        let steer = P5Vector.sub (desired, _velocity)
        steer.limit maxForce // Limit to maximum steering force

        steer

    member private _.render(p5: P5) : Unit =
        // Draw a triangle rotated in the direction of velocity
        let theta = _velocity.heading () + radians p5 90
        fill p5 (Grayscale 127)
        stroke p5 (Grayscale 200)
        push p5
        translate p5 _position.x _position.y
        rotate p5 theta
        beginShape p5
        vertex p5 0 (-r * 2.0)
        vertex p5 -r (r * 2.0)
        vertex p5 r (r * 2.0)
        endShapeAndClose p5
        pop p5

    member private _.borders(p5: P5) =
        let width = width p5 |> float
        let height = height p5 |> float

        if _position.x < -r then
            do _position.x <- width + r

        if _position.y < -r then
            do _position.y <- height + r

        if _position.x > width + r then
            do _position.x <- -r

        if _position.y > height + r then
            do _position.y <- -r

    member private _.separate(boids: Boid list) : P5Vector =
        let desiredseparation = 25.0

        let isTooClose (boid: Boid) =
            let d = P5Vector.dist (_position, boid.position)
            d > 0 && d < desiredseparation

        // For every boid in the system, check if it's too close
        let closeBoids = boids |> List.filter isTooClose

        // Calculate vector pointing away from neighbor
        let getDiff (boid: Boid) =
            let d = P5Vector.dist (_position, boid.position)
            let diff = P5Vector.sub (_position, boid.position)
            diff.normalize ()
            diff.divScalar d // Weight by distance
            diff

        let steer =
            closeBoids
            |> List.map getDiff
            |> List.fold (fun steer diff -> P5Vector.add (steer, diff)) (P5Vector.create (0, 0))

        // Average -- divide by how many
        if List.isEmpty closeBoids |> not then
            do steer.divScalar (List.length closeBoids)

        // As long as the vector is greater than 0
        if steer.mag () > 0 then
            do
                // Implement Reynolds: Steering = Desired - Velocity
                steer.normalize ()
                steer.multScalar maxSpeed
                steer.subVector _velocity
                steer.limit maxForce

        steer

    member private _.getNeighbors(boids: Boid list) : Boid list =
        let neighbordist = 50

        let isNeighbor (boid: Boid) =
            let d = P5Vector.dist (_position, boid.position)
            d > 0 && d < neighbordist

        List.filter isNeighbor boids

    member private self.align(boids: Boid list) : P5Vector =
        let neighbors = self.getNeighbors boids

        let sum =
            neighbors
            |> List.map (fun (b: Boid) -> b.velocity)
            |> List.fold (fun a b -> P5Vector.add (a, b)) (P5Vector.create (0, 0))

        if List.isEmpty neighbors |> not then
            sum.divScalar (List.length neighbors)
            sum.normalize ()
            sum.multScalar maxSpeed
            let steer = P5Vector.sub (sum, _velocity)
            steer.limit maxForce

            steer
        else
            P5Vector.create (0, 0)

    member private self.cohesion(boids: Boid list) : P5Vector =
        let neighbors = self.getNeighbors boids

        if List.isEmpty neighbors |> not then
            let sum =
                neighbors
                |> List.map (fun b -> b.position)
                |> List.fold (fun s p -> P5Vector.add (s, p)) (P5Vector.create (0, 0))

            sum.divScalar (List.length neighbors)
            self.seek (sum)
        else
            P5Vector.create (0, 0)

type Flock() =
    let mutable boids: Boid list = []

    member _.run(p5: P5) =
        List.iter (fun (b: Boid) -> b.run p5 boids) boids

    member _.addBoid(b: Boid) = boids <- b :: boids


let setup p5 =
    createCanvas p5 720 360
    let centerX = 720 / 2
    let centerY = 360 / 2

    let flock = new Flock()

    { 1..100 }
    |> Seq.map (fun _ -> new Boid(centerX, centerY))
    |> Seq.iter flock.addBoid

    flock

let draw p5 (flock: Flock) =
    background p5 (Name "#f5f7ff")
    flock.run p5

let onMouseDragged p5 _ (flock: Flock) =
    flock.addBoid (new Boid(mouseX p5, mouseY p5))
    flock

let subscriptions = [ OnMouseDragged(Update onMouseDragged) ]

let run node =
    play node setup noUpdate draw subscriptions
