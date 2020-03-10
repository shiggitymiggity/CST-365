<template>
    <div class="links">
        <span v-on:click='goToHome'>Home</span>
        <span v-on:click='goToTables'>Students</span>
        <span v-on:click='goToForms'>Instructors</span>

      <!-- Not sure if all this goes here... -->
      <!-- Check that the SDK client is not currently loading before accessing is methods -->
      <div v-if="!$auth.loading">
      <!-- show login when not authenticated -->
      <button v-if="!$auth.isAuthenticated" @click="login">Log in</button>
      <!-- show logout when authenticated -->
      <button v-if="$auth.isAuthenticated" @click="logout">Log out</button>
    </div>

    </div>
</template>

<script>
  export default {
    name: 'NavBar',
    methods: {
      goToHome: function() {
        this.$router.push({ path: 'home' })
      },
      goToTables: function() {
        this.$router.push({ path: 'Students' })
      },
      goToForms: function() {
        this.$router.push({ path: 'Instructors' })
      },
      
      // Log the user in
      login() {
      this.$auth.loginWithRedirect();
      },
      // Log the user out
      logout() {
      this.$auth.logout({
        returnTo: window.location.origin
      });
    }

    }
  }
</script>

<style scoped>
  span {
      font-family: monospace;
      font-weight: bold;
      font-size: 14pt;
      cursor: pointer;
      padding-right: 20px;
      background-color: white;
      text-align: center;
  }
  .links {
      background-color: lightgray;
      margin-top: 20px;
      padding: 10px;
  }
</style>