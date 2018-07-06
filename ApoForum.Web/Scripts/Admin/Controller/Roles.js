app.controller('admin-roles-controller', function ($scope, $http, $route) {
    $http.get("RolesList")
    .success(function (response) {
        $scope.roles = response;
    });

    $scope.addRole = function () { 
        $http.post("AddRole",{roleName : $scope.roleName}).success(function (response) {
            if (response) {
                $route.reload();
            }
        });
    }

    $scope.deleteRole = function (id) {
        $http.post("DeleteRole", { roleId: id }).success(function (response) {
            if (response) {
                $route.reload();
            }

        });
    }
});

