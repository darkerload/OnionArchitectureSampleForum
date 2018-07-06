app.controller('admin-users-controller', function ($scope, $http, $route) {
    $http.get("UsersList").success(function (response) {
        $scope.users = response;
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

    $scope.getUser = function (id) {
        var divId = "div#" + id + ".userDetailRegion";

        $(divId).slideToggle("slow", function () {

            $http.get("UserDetail", { params: { userId: id } }).success(function (response) {
                $(divId).html(response);
            });

        });
    }

});

