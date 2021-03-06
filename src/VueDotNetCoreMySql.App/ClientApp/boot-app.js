require("./init");

// Installed modules import
import Vue from "vue";
import * as uiv from "uiv";
import Vuelidate from "vuelidate";

// import VueSplit from "vue-split-panel";

// Custom modules import
import store from "@/store/index";
import router from "@/router";
import App from "@/components/App";

import "@/components";

Vue.use(uiv);
Vue.use(Vuelidate);

/** Vue JS Configurations */
Vue.config.productionTip = false;

Vue.config.devtools = true;

/** Rendering  */
new Vue({
  store,
  router,
  ...App
});
