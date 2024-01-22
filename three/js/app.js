/**
 * ! You need 3 things:
 * 1. Scene
 * 2. Camera 
 * 3. Renderer
 */ 

const EGUN = THREE;
// import { OrbitControls } from "https://threejs.org/examples/jsm/controls/OrbitControls.js";

const scene = new EGUN.Scene();

// field of view, aspect ratio, near and far clipping plane
const camera = new EGUN.PerspectiveCamera( 75, window.innerWidth / window.innerHeight, 0.1, 1000);
const renderer = new EGUN.WebGLRenderer();

renderer.setSize( window.innerWidth, window.innerHeight );
document.body.appendChild( renderer.domElement );

const controls = new EGUN.OrbitControls( camera, renderer.domElement );

// Cube
const geometry = new EGUN.BoxGeometry( 1, 1, 1 );
const material = new EGUN.MeshBasicMaterial( { color: 0x00ff00 } );
const cube = new EGUN.Mesh( geometry, material );
scene.add( cube );

camera.position.z = 5;

// Render the Scene or animate Loop else you won't see anything.
function animate()
{
    requestAnimationFrame( animate );
    cube.rotation.x += 0.01;
    cube.rotation.y += 0.01;
    renderer.render( scene, camera );
}

animate();