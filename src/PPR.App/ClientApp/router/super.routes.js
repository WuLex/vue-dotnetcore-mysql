function page(path) {
  return () =>
    import( /* webpackChunkName: '' */ `@/pages/${path}`).then(
      m => m.default || m
    );
}

export default [
  {
    path: "*",
    component: page("404.vue")
  }
];
