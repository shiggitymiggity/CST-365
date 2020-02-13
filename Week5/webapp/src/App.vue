<template>
  <div id="app">
    <NavBar/>
    <router-view/>
  </div>
</template>

<script>
import NavBar from './components/NavBar.vue'

export default {
  name: 'App',
  components: {
    NavBar
  }
}
</script>

<style>
#myHeader 
{
    background-color: rgb(160, 160, 160);
    color: rgb(5, 255, 5);
    padding: 40px;
    font-size:5em;
    text-align: center;
}

body
{
	background-color: rgb(160, 160, 160);
	font-family: Veranda; 
}

h1
{
	color: rgb(0, 0, 0);
	font-family: Veranda;
	font-size: 2em;
}


h2
{	
	color: rgb(0, 0, 0);
	font-family: Veranda; 
	font-size: 4em;
}

p {
	text-align: center;
	padding: 0 1em;
	color: rgb(0, 0, 0);
	background-color: rgb(160, 160, 160);
	font-family: Veranda;
	font-size: 1.5em;
	display: block;
    max-width: 900px;
    margin: 0 auto 1.5em;
	padding: 0 1em;
}

table {
    font-family: Times, serif;
    border-collapse: collapse;
    width: 100%;
  }

  td, th {
    border: 1px solid rgb(199, 206, 228);
    text-align: left;
    padding: 8px;
  }

  tr:nth-child(even) {
    background-color: rgb(199, 206, 228);
  }

.center 
{
    display: block;
    margin-left: auto;
    margin-right: auto;
}



/* hyperlinks */
a:link {
    color: rgb(160, 160, 160);
	font-family: Veranda;
    background-color: transparent;
    text-decoration: none;
	}
	
a:visited {
    color: rgb(160, 160, 160);
	font-family: Veranda;
    background-color: transparent;
    text-decoration: none;
	}
	
/* Add a black background color to the top navigation */
.topnav {
    position: fixed;
	top: 0;
	width: 100%;
    background-color: rgb(160, 160, 160);
    overflow: hidden;
	z-index: 99999;
}

/* Style the links inside the navigation bar */
.topnav a {
  background-color:  rgb(160, 160, 160);
  float: left;
  color: black;
  font-family: Veranda;
  text-align: center;
  padding: 14px 16px;
  text-decoration: none;
  font-size: 17px;
}

/* Change the color of links on hover */
.topnav a:hover {
  background-color: #ddd;
  color: black;
}


/* Centered section inside the top navigation */
.topnav-centered a {
  float: none;
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
}

/* Right-aligned section inside the top navigation */
.topnav-right {
  float: right;
}

/* Responsive navigation menu - display links on top of each other instead of next to each other (for mobile devices) */
@media screen and (max-width: 600px) {
  .topnav a, .topnav-right {
    float: none;
    display: block;
  }

  .topnav-centered a {
    position: relative;
    top: 0;
    left: 0;
    transform: none;
  }
}

body, html {
    height: 100%;
}


</style>
