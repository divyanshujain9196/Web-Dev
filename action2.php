<?php
   if( $_POST["name"] || $_POST["Address"]|| $_POST["Phone"] ) {
      
    echo "Name is ". $_POST['name']. "<br />";
    echo "Address is ". $_POST['Address']. "<br/>";
    echo "phone No. is ". $_POST['Phone'];
      exit();
   }
?>