<template>
  <div>
    <loading :active.sync="isLoading"></loading>
    <div class="ibox shadow-md-down" v-show="!isLoading">
      <div class="ibox-content">
        <div class="table-responsive">
          Admin Dashboard
          <!-- <data-table
            ref="table"
            :fields="fields"
            :opts="options"
            :details="details"
            @before-creating="doLoadTable"
            @iteration="iteration"
          ></data-table>-->
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import Loading from "vue-loading-overlay";
import { mapGetters } from "vuex";

// import DataTable from "@/components/DataTable";
import { helpers } from "@/utils";

export default {
  components: { Loading },

  data() {
    const vm = this;
    return {
      helpers: helpers,
      response: [],
      fullPage: true,
      isLoading: false,
      limit: 30,
      page: 1,
      dialog: false,
      index: 0
    };
  },

  computed: {},

  mounted() {
    const vm = this;
    vm.doLoadTable();
  },
  beforeDestroy() {
    this.$root.$off();
  },

  methods: {
    showPopup(data) {
      this.$refs.popup.show(data);
    },

    // DT

    doLoadTable() {
      const vm = this;
      const table = vm.$refs.table;
      vm.isLoading = true;

      vm.helpers.get("/api/account/allusers").then(({ data }) => {
        vm.isLoading = false;
      });
    },
    iteration(row) {}
  }
};
</script>
